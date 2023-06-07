using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using LotDetails.DataAccess.Model;
using LotDetails.DataAccess.Repository;
using System.Linq;

namespace LotDetailsEFCore
{
    public class Function1
    {
        //private readonly AppDBContext _appDBContext;
        private readonly IEntityBaseRepository<LotType> _lotTypeRepo; 

        //public Function1(AppDBContext appDBContext)
        //{
        //    _appDBContext = appDBContext;
        //}

        public Function1(IEntityBaseRepository<LotType> lotTypeRepo)
        {
            _lotTypeRepo = lotTypeRepo;
        }

        [FunctionName("Function1")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            string responseMessage = string.IsNullOrEmpty(name)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {name}. This HTTP triggered function executed successfully.";

            List<LotType> lotTypes = null;
            try
            {
                //lotTypes = await _appDBContext.LotTypes.ToListAsync();
                lotTypes = _lotTypeRepo.GetAll().ToList();
            }
            catch (Exception ex)
            {

                throw;
            }

            return new OkObjectResult(lotTypes);
        }
    }
}
