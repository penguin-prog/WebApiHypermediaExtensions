﻿using System;
using Newtonsoft.Json;

namespace Bluehands.Hypermedia.Client.Extensions.NewtonsoftJson
{
    public static class NewtonsoftJsonExtensions
    {
        /// <summary>
        /// Incoming JSON strings will be parsed using the Newtonsoft.Json library
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static HypermediaResolverBuilder WithNewtonsoftJsonStringParser(this HypermediaResolverBuilder builder)
        {
            return builder.WithCustomStringParser(() => new NewtonsoftJsonStringParser());
        }

        /// <summary>
        /// Outgoing objects will be serialized to JSON using the Newtonsoft.Json library
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="formatting"></param>
        /// <returns></returns>
        public static HypermediaResolverBuilder WithNewtonsoftJsonObjectParameterSerializer(this HypermediaResolverBuilder builder, Formatting formatting = Formatting.None)
        {
            return builder.WithCustomParameterSerializer(() => new NewtonsoftJsonObjectParameterSerializer(formatting));
        }


        /// <summary>
        /// Outgoing objects will be serialized into a JSON wrapper object using the Newtonsoft.Json library
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="formatting"></param>
        /// <returns></returns>
        public static HypermediaResolverBuilder WithSingleNewtonsoftJsonObjectParameterSerializer(this HypermediaResolverBuilder builder, Formatting formatting = Formatting.None)
        {
            return builder.WithCustomParameterSerializer(() => new SingleNewtonsoftJsonObjectParameterSerializer(formatting));
        }

        /// <summary>
        /// Incoming problem-JSON strings will be parsed using the Newtonsoft.JSON library
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static HypermediaResolverBuilder WithNewtonsoftJsonProblemReader(this HypermediaResolverBuilder builder)
        {
            return builder.WithCustomProblemStringReader(() => new NewtonsoftJsonProblemStringReader());
        }
    }
}
