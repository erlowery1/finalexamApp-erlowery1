using System;
using api.Controllers.interfaces;

namespace api.Controllers.models
{
    public class DeepDish : ICook //implementing interface
    {
        public string Cook()
        {
            //printing message
            return("the pizza is cooking and will be ready in 10 minutes");
        }
    }
}