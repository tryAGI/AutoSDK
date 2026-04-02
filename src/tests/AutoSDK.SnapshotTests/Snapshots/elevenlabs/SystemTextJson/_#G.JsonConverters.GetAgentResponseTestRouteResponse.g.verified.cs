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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetAgentResponseTestRouteResponseDiscriminator>(ref readerCopy, options);

            global::G.GetResponseUnitTestResponseModel? llm = default;
            if (discriminator?.Type == global::G.GetAgentResponseTestRouteResponseDiscriminatorType.Llm)
            {
                llm = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetResponseUnitTestResponseModel>(ref reader, options);
            }
            global::G.GetToolCallUnitTestResponseModel? tool = default;
            if (discriminator?.Type == global::G.GetAgentResponseTestRouteResponseDiscriminatorType.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetToolCallUnitTestResponseModel>(ref reader, options);
            }
            global::G.GetSimulationTestResponseModel? simulation = default;
            if (discriminator?.Type == global::G.GetAgentResponseTestRouteResponseDiscriminatorType.Simulation)
            {
                simulation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetSimulationTestResponseModel>(ref reader, options);
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

            if (value.IsLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeof(global::G.GetResponseUnitTestResponseModel), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::G.GetToolCallUnitTestResponseModel), options);
            }
            else if (value.IsSimulation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Simulation, typeof(global::G.GetSimulationTestResponseModel), options);
            }
        }
    }
}