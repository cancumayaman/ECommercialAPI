using ECommercialAPI.Application.Repositories;
using ECommercialAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommercialAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository,
            IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository,
            IOrderReadRepository orderReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            Order order = await _orderReadRepository.GetByIdAsync("41317a1b-2bcb-43e8-b507-6630e817ea79");
            order.Address = "İzmir";
            await _orderWriteRepository.SaveAsync();
        }
    }
}
