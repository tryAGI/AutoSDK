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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnitTestRunResponseModelTestInfoVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnitTestRunResponseModelTestInfoVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UnitTestRunResponseModelTestInfoVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ResponseUnitTestModel? llm = default;
            if (discriminator?.Type == global::G.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseUnitTestModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseUnitTestModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResponseUnitTestModel)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolCallUnitTestModel? tool = default;
            if (discriminator?.Type == global::G.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallUnitTestModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallUnitTestModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolCallUnitTestModel)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SimulationTestModel? simulation = default;
            if (discriminator?.Type == global::G.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Simulation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SimulationTestModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SimulationTestModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SimulationTestModel)}");
                simulation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseUnitTestModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseUnitTestModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseUnitTestModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolCallUnitTestModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolCallUnitTestModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolCallUnitTestModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
            else if (value.IsSimulation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SimulationTestModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SimulationTestModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SimulationTestModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Simulation, typeInfo);
            }
        }
    }
}