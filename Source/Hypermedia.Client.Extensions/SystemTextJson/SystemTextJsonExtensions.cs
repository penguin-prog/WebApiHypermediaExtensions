﻿using System.Text.Json;

namespace Bluehands.Hypermedia.Client.Extensions.SystemTextJson
{
    public static class SystemTextJsonExtensions
    {
        /// <summary>
        /// Incoming JSON strings will be parsed using the System.Text.Json library
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static HypermediaClientBuilder WithSystemTextJsonStringParser(this HypermediaClientBuilder builder)
        {
            return builder.WithCustomStringParser(() => new SystemTextJsonStringParser());
        }

        /// <summary>
        /// Outgoing objects will be serialized to JSON using the System.Text.Json library
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static HypermediaClientBuilder WithSystemTextJsonObjectParameterSerializer(this HypermediaClientBuilder builder, JsonSerializerOptions options = null)
        {
            return builder.WithCustomParameterSerializer(() => new SystemTextJsonObjectParameterSerializer(options));
        }

        /// <summary>
        /// Outgoing objects will be serialized into a JSON wrapper object using the System.Text.Json library
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static HypermediaClientBuilder WithSingleSystemTextJsonObjectParameterSerializer(this HypermediaClientBuilder builder, JsonWriterOptions options = default)
        {
            return builder.WithCustomParameterSerializer(() => new SingleSystemTextJsonObjectParameterSerializer(options));
        }

        /// <summary>
        /// Incoming problem-JSON strings will be parsed using the System.Text.Json library
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static HypermediaClientBuilder WithSystemTextJsonProblemReader(this HypermediaClientBuilder builder)
        {
            return builder.WithCustomProblemStringReader(() => new SystemTextJsonProblemStringReader());
        }
    }
}
