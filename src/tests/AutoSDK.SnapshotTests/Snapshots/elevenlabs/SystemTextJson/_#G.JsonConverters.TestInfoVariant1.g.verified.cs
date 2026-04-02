//HintName: G.JsonConverters.TestInfoVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TestInfoVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TestInfoVariant1>
    {
        /// <inheritdoc />
        public override global::G.TestInfoVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UnitTestRunResponseModelTestInfoVariant1Discriminator>(ref readerCopy, options);

            global::G.ResponseUnitTestModel? llm = default;
            if (discriminator?.Type == global::G.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Llm)
            {
                llm = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResponseUnitTestModel>(ref reader, options);
            }
            global::G.ToolCallUnitTestModel? tool = default;
            if (discriminator?.Type == global::G.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ToolCallUnitTestModel>(ref reader, options);
            }
            global::G.SimulationTestModel? simulation = default;
            if (discriminator?.Type == global::G.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Simulation)
            {
                simulation = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SimulationTestModel>(ref reader, options);
            }

            var __value = new global::G.TestInfoVariant1(
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
            global::G.TestInfoVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeof(global::G.ResponseUnitTestModel), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::G.ToolCallUnitTestModel), options);
            }
            else if (value.IsSimulation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Simulation, typeof(global::G.SimulationTestModel), options);
            }
        }
    }
}