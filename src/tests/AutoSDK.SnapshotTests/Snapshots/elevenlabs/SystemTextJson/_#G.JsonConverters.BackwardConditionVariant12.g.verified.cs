//HintName: G.JsonConverters.BackwardConditionVariant12.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BackwardConditionVariant12JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BackwardConditionVariant12>
    {
        /// <inheritdoc />
        public override global::G.BackwardConditionVariant12 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowEdgeModelOutputBackwardConditionVariant1Discriminator>(ref readerCopy, options);

            global::G.WorkflowUnconditionalModelOutput? unconditional = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType.Unconditional)
            {
                unconditional = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowUnconditionalModelOutput>(ref reader, options);
            }
            global::G.WorkflowLLMConditionModelOutput? llm = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType.Llm)
            {
                llm = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowLLMConditionModelOutput>(ref reader, options);
            }
            global::G.WorkflowResultConditionModelOutput? result = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType.Result)
            {
                result = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowResultConditionModelOutput>(ref reader, options);
            }
            global::G.WorkflowExpressionConditionModelOutput? expression = default;
            if (discriminator?.Type == global::G.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorType.Expression)
            {
                expression = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowExpressionConditionModelOutput>(ref reader, options);
            }

            var __value = new global::G.BackwardConditionVariant12(
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
            global::G.BackwardConditionVariant12 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsUnconditional)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unconditional, typeof(global::G.WorkflowUnconditionalModelOutput), options);
            }
            else if (value.IsLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeof(global::G.WorkflowLLMConditionModelOutput), options);
            }
            else if (value.IsResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Result, typeof(global::G.WorkflowResultConditionModelOutput), options);
            }
            else if (value.IsExpression)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Expression, typeof(global::G.WorkflowExpressionConditionModelOutput), options);
            }
        }
    }
}