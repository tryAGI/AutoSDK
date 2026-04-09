//HintName: G.JsonConverters.StepsItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class StepsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.StepsItem2>
    {
        /// <inheritdoc />
        public override global::G.StepsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolResponseModelOutputStepDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolResponseModelOutputStepDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowToolResponseModelOutputStepDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.WorkflowToolEdgeStepModel? edge = default;
            if (discriminator?.Type == global::G.WorkflowToolResponseModelOutputStepDiscriminatorType.Edge)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolEdgeStepModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolEdgeStepModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowToolEdgeStepModel)}");
                edge = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowToolNestedToolsStepModelOutput? nestedTools = default;
            if (discriminator?.Type == global::G.WorkflowToolResponseModelOutputStepDiscriminatorType.NestedTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolNestedToolsStepModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolNestedToolsStepModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowToolNestedToolsStepModelOutput)}");
                nestedTools = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowToolMaxIterationsExceededStepModel? maxIterationsExceeded = default;
            if (discriminator?.Type == global::G.WorkflowToolResponseModelOutputStepDiscriminatorType.MaxIterationsExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolMaxIterationsExceededStepModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolMaxIterationsExceededStepModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowToolMaxIterationsExceededStepModel)}");
                maxIterationsExceeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.StepsItem2(
                discriminator?.Type,
                edge,

                nestedTools,

                maxIterationsExceeded
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.StepsItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEdge)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolEdgeStepModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolEdgeStepModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowToolEdgeStepModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Edge!, typeInfo);
            }
            else if (value.IsNestedTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolNestedToolsStepModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolNestedToolsStepModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowToolNestedToolsStepModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NestedTools!, typeInfo);
            }
            else if (value.IsMaxIterationsExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolMaxIterationsExceededStepModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolMaxIterationsExceededStepModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowToolMaxIterationsExceededStepModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxIterationsExceeded!, typeInfo);
            }
        }
    }
}