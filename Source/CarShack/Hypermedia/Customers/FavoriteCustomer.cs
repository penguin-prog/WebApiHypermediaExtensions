﻿using System.ComponentModel.DataAnnotations;
using WebApi.HypermediaExtensions.Hypermedia.Actions;
using WebApi.HypermediaExtensions.JsonSchema;

namespace CarShack.Hypermedia.Customers
{
    public class FavoriteCustomer : IHypermediaActionParameter
    {
        //[Required]
        //[Url]
        //public string CustomerLink { get; set; }

        [Required]
        [KeyFromUri(typeof(HypermediaCustomer), schemaProperyName: "Customer", routeTemplateParameterName: null)]
        public int CustomerId { get; set; }
    }
}