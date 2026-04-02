//HintName: G.JsonConverters.ForwardConditionVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ForwardConditionVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ForwardConditionVariant1>
    {
        /// <inheritdoc />
        public override global::G.ForwardConditionVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowEdgeModelInputForwardConditionVariant1Discriminator>(ref readerCopy, options);

            global::G.WorkflowUnconditionalModelInput? unconditional = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType.Unconditional)
            {
                unconditional = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowUnconditionalModelInput>(ref reader, options);
            }
            global::G.WorkflowLLMConditionModelInput? llm = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType.Llm)
            {
                llm = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowLLMConditionModelInput>(ref reader, options);
            }
            global::G.WorkflowResultConditionModelInput? result = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType.Result)
            {
                result = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowResultConditionModelInput>(ref reader, options);
            }
            global::G.WorkflowExpressionConditionModelInput? expression = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorType.Expression)
            {
                expression = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowExpressionConditionModelInput>(ref reader, options);
            }

            var __value = new global::G.ForwardConditionVariant1(
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
            global::G.ForwardConditionVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsUnconditional)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unconditional, typeof(global::G.WorkflowUnconditionalModelInput), options);
            }
            else if (value.IsLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeof(global::G.WorkflowLLMConditionModelInput), options);
            }
            else if (value.IsResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Result, typeof(global::G.WorkflowResultConditionModelInput), options);
            }
            else if (value.IsExpression)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Expression, typeof(global::G.WorkflowExpressionConditionModelInput), options);
            }
        }
    }
}