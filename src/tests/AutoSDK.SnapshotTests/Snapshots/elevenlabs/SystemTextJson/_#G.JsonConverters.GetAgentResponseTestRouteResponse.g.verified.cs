//HintName: G.JsonConverters.GetAgentResponseTestRouteResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GetAgentResponseTestRouteResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetAgentResponseTestRouteResponse>
    {
        /// <inheritdoc />
        public override global::G.GetAgentResponseTestRouteResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetAgentResponseTestRouteResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetAgentResponseTestRouteResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetAgentResponseTestRouteResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.GetResponseUnitTestResponseModel? llm = default;
            if (discriminator?.Type == global::G.GetAgentResponseTestRouteResponseDiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetResponseUnitTestResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetResponseUnitTestResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetResponseUnitTestResponseModel)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetToolCallUnitTestResponseModel? tool = default;
            if (discriminator?.Type == global::G.GetAgentResponseTestRouteResponseDiscriminatorType.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetToolCallUnitTestResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetToolCallUnitTestResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetToolCallUnitTestResponseModel)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetSimulationTestResponseModel? simulation = default;
            if (discriminator?.Type == global::G.GetAgentResponseTestRouteResponseDiscriminatorType.Simulation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetSimulationTestResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetSimulationTestResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetSimulationTestResponseModel)}");
                simulation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.GetAgentResponseTestRouteResponse(
                discriminator?.Type,
                llm,

                tool,

                simulation
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetAgentResponseTestRouteResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetResponseUnitTestResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetResponseUnitTestResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetResponseUnitTestResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetToolCallUnitTestResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetToolCallUnitTestResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetToolCallUnitTestResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
            else if (value.IsSimulation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetSimulationTestResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetSimulationTestResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetSimulationTestResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Simulation, typeInfo);
            }
        }
    }
}