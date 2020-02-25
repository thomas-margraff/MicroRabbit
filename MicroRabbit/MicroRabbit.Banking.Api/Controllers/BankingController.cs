using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly ILogger<BankingController> _logger;

        public BankingController(IAccountService accountService,
                                 ILogger<BankingController> logger)
        {
            if (accountService is null)
            {
                throw new ArgumentNullException(nameof(accountService));
            }

            this._accountService = accountService;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts().ToList());
        }
    }
}
