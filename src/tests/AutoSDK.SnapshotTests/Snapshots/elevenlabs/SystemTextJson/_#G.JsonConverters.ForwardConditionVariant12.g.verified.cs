//HintName: G.JsonConverters.ForwardConditionVariant12.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ForwardConditionVariant12JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ForwardConditionVariant12>
    {
        /// <inheritdoc />
        public override global::G.ForwardConditionVariant12 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowEdgeModelOutputForwardConditionVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowEdgeModelOutputForwardConditionVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowEdgeModelOutputForwardConditionVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.WorkflowUnconditionalModelOutput? unconditional = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Unconditional)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowUnconditionalModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowUnconditionalModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowUnconditionalModelOutput)}");
                unconditional = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowLLMConditionModelOutput? llm = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowLLMConditionModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowLLMConditionModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowLLMConditionModelOutput)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowResultConditionModelOutput? result = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Result)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowResultConditionModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowResultConditionModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowResultConditionModelOutput)}");
                result = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.WorkflowExpressionConditionModelOutput? expression = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Expression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowExpressionConditionModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowExpressionConditionModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.WorkflowExpressionConditionModelOutput)}");
                expression = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ForwardConditionVariant12(
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
            global::G.ForwardConditionVariant12 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUnconditional)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowUnconditionalModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowUnconditionalModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowUnconditionalModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unconditional!, typeInfo);
            }
            else if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowLLMConditionModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowLLMConditionModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowLLMConditionModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm!, typeInfo);
            }
            else if (value.IsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowResultConditionModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowResultConditionModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowResultConditionModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Result!, typeInfo);
            }
            else if (value.IsExpression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WorkflowExpressionConditionModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WorkflowExpressionConditionModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WorkflowExpressionConditionModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Expression!, typeInfo);
            }
        }
    }
}