using DependencyInjectionLibrary.Interface;
using DependencyInjectionLibrary.Utilities;
using System;

namespace DependencyInjectionLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        private readonly IDataAccess dataAccess;
        private readonly ILogger logger;

        public BusinessLogic(IDataAccess dataAccess, ILogger logger)
        {
            this.dataAccess = dataAccess;
            this.logger = logger;
        }
        public void ProcessData()
        {
            //Before Dependency Inversion
            //DataAccess dataAccess = new DataAccess();
            //Logger logger = new Logger();

            //logger.Log("Starting of processing data");
            //Console.WriteLine("Processing the data");
            //dataAccess.LoadData();
            //dataAccess.SaveData("ProcessedInfo");
            //logger.Log("Finished processing of the data");


            //After Dependency Inversion
            logger.Log("Starting of processing data");
            Console.WriteLine("Processing the data");
            dataAccess.LoadData();
            dataAccess.SaveData("ProcessedInfo");
            logger.Log("Finished processing of the data");
        }
    }
}
