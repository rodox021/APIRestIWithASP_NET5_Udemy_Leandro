using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIRestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;



        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {

            if (IsNumeric(firstNumber) && IsNumeric(firstNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }


        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Sub(string firstNumber, string secondNumber)
        {

            if (IsNumeric(firstNumber) && IsNumeric(firstNumber))
            {
                var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }
            return BadRequest("Invalid Input");
        }


        [HttpGet("multi/{firstNumber}/{secondNumber}")]
        public IActionResult Multi(string firstNumber, string secondNumber)
        {

            if (IsNumeric(firstNumber) && IsNumeric(firstNumber))
            {
                var multi = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(multi.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Div(string firstNumber, string secondNumber)
        {
            try
            {
                if (IsNumeric(firstNumber) && IsNumeric(firstNumber))
                {
                    var div = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                    return Ok(div.ToString());
                }

                return BadRequest("Invalid Input");
            }
            catch (DivideByZeroException)
            {

                return BadRequest("Invalid: Can't divide by zero ou Ivalid Imput");
            }
            catch (Exception)
            {

                return BadRequest("Invalid Input");
            }

        }



        #region // Metodos Auxiliares
        private bool IsNumeric(string strNumber)
        {
            double number;

            bool isNumber = double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number
                );
            return isNumber;
        }
        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }
        #endregion

    }
}
