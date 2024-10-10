using Xunit;
using CAFallAPI.Controllers;
using Microsoft.EntityFrameworkCore;
using CAFallAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CAFallAPI;
using Assert = Xunit.Assert;

public class OrderControllerTests
{
    private readonly OrderController _controller;
    private readonly DbContextOptions<AppDbContext> _options;

    public OrderControllerTests()
    {
        _options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _controller = new OrderController(new AppDbContext(_options));
    }

    [Fact]
    public async Task PlaceOrder_ReturnsCreatedResult()
    {
        var order = new Order {};

        var result = await _controller.PlaceOrder(order);

        Assert.IsType<CreatedAtActionResult>(result);
    }
    
    [Fact]
    public async Task GetOrderHistory_ReturnsOkResult()
    {
        var result = await _controller.GetOrderHistory();

        var okResult = Assert.IsType<OkObjectResult>(result);
        var orders = Assert.IsType<List<Order>>(okResult.Value);
        Assert.NotEmpty(orders);
    }

}
