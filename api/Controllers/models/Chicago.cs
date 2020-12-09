using System;
using api.Controllers.interfaces;

namespace api.Controllers.models
{
    public class Chicago : ICook //implementing interface
    {
        //printing out message
        public string Cook()
        {
            return ("the pizza is cooking and will be ready in 20 minutes");
        }
    }
}