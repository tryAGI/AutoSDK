//HintName: G.JsonConverters.StepsItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class StepsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.StepsItem>
    {
        /// <inheritdoc />
        public override global::G.StepsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolResponseModelInputStepDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolResponseModelInputStepDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowToolResponseModelInputStepDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.WorkflowToolEdgeStepModel? edge = default;
            if (discriminator?.Type == global::G.WorkflowToolResponseModelInputStepDiscriminatorType.Edge)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolEdgeStepModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolEdgeStepModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowToolEdgeStepModel)}");
                edge = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowToolNestedToolsStepModelInput? nestedTools = default;
            if (discriminator?.Type == global::G.WorkflowToolResponseModelInputStepDiscriminatorType.NestedTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolNestedToolsStepModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolNestedToolsStepModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowToolNestedToolsStepModelInput)}");
                nestedTools = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowToolMaxIterationsExceededStepModel? maxIterationsExceeded = default;
            if (discriminator?.Type == global::G.WorkflowToolResponseModelInputStepDiscriminatorType.MaxIterationsExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolMaxIterationsExceededStepModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolMaxIterationsExceededStepModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowToolMaxIterationsExceededStepModel)}");
                maxIterationsExceeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.StepsItem(
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
            global::G.StepsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEdge)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolEdgeStepModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolEdgeStepModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowToolEdgeStepModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Edge, typeInfo);
            }
            else if (value.IsNestedTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolNestedToolsStepModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolNestedToolsStepModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowToolNestedToolsStepModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NestedTools, typeInfo);
            }
            else if (value.IsMaxIterationsExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowToolMaxIterationsExceededStepModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowToolMaxIterationsExceededStepModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowToolMaxIterationsExceededStepModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxIterationsExceeded, typeInfo);
            }
        }
    }
}