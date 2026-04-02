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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowToolResponseModelOutputStepDiscriminator>(ref readerCopy, options);

            global::G.WorkflowToolEdgeStepModel? edge = default;
            if (discriminator?.Type == global::G.WorkflowToolResponseModelOutputStepDiscriminatorType.Edge)
            {
                edge = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowToolEdgeStepModel>(ref reader, options);
            }
            global::G.WorkflowToolNestedToolsStepModelOutput? nestedTools = default;
            if (discriminator?.Type == global::G.WorkflowToolResponseModelOutputStepDiscriminatorType.NestedTools)
            {
                nestedTools = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowToolNestedToolsStepModelOutput>(ref reader, options);
            }
            global::G.WorkflowToolMaxIterationsExceededStepModel? maxIterationsExceeded = default;
            if (discriminator?.Type == global::G.WorkflowToolResponseModelOutputStepDiscriminatorType.MaxIterationsExceeded)
            {
                maxIterationsExceeded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowToolMaxIterationsExceededStepModel>(ref reader, options);
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

            if (value.IsEdge)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Edge, typeof(global::G.WorkflowToolEdgeStepModel), options);
            }
            else if (value.IsNestedTools)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NestedTools, typeof(global::G.WorkflowToolNestedToolsStepModelOutput), options);
            }
            else if (value.IsMaxIterationsExceeded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxIterationsExceeded, typeof(global::G.WorkflowToolMaxIterationsExceededStepModel), options);
            }
        }
    }
}