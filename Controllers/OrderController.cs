﻿using System;
using AutoMapper;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppRestaurant.Models;
using AppRestaurant.Data;
using AppRestaurant.Models;

namespace AppRestaurant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private static List<Order> orders = new List<Order>();
        //private static int id = 1;
        // private RestaurantContext _context;
        // private IMapper _mapper;

        // public OrderController(RestaurantContext context, Imapper){

        // }

        [HttpGet]
        public IActionResult RetrieveOrder()
        {
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public IActionResult RetrieveOrdersForId(int id)
        {
            Order order = orders.FirstOrDefault(order => order.Id == id);
            if(order != null){
                return Ok(order);
            }
            return NotFound();
        }
        
    }
}
