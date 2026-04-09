//HintName: G.JsonConverters.BackwardConditionVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BackwardConditionVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BackwardConditionVariant1>
    {
        /// <inheritdoc />
        public override global::G.BackwardConditionVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowEdgeModelInputBackwardConditionVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowEdgeModelInputBackwardConditionVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowEdgeModelInputBackwardConditionVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.WorkflowUnconditionalModelInput? unconditional = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Unconditional)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowUnconditionalModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowUnconditionalModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowUnconditionalModelInput)}");
                unconditional = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowLLMConditionModelInput? llm = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowLLMConditionModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowLLMConditionModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowLLMConditionModelInput)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowResultConditionModelInput? result = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Result)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowResultConditionModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowResultConditionModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowResultConditionModelInput)}");
                result = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowExpressionConditionModelInput? expression = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Expression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowExpressionConditionModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowExpressionConditionModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowExpressionConditionModelInput)}");
                expression = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.BackwardConditionVariant1(
                discriminator?.Type,
                unconditional,

                llm,

                result,

                expression
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BackwardConditionVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUnconditional)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowUnconditionalModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowUnconditionalModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowUnconditionalModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unconditional!, typeInfo);
            }
            else if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowLLMConditionModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowLLMConditionModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowLLMConditionModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm!, typeInfo);
            }
            else if (value.IsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowResultConditionModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowResultConditionModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowResultConditionModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Result!, typeInfo);
            }
            else if (value.IsExpression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowExpressionConditionModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowExpressionConditionModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowExpressionConditionModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Expression!, typeInfo);
            }
        }
    }
}