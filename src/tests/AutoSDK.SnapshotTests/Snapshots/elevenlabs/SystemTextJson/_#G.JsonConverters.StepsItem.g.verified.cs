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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowToolResponseModelInputStepDiscriminator>(ref readerCopy, options);

            global::G.WorkflowToolEdgeStepModel? edge = default;
            if (discriminator?.Type == global::G.WorkflowToolResponseModelInputStepDiscriminatorType.Edge)
            {
                edge = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowToolEdgeStepModel>(ref reader, options);
            }
            global::G.WorkflowToolNestedToolsStepModelInput? nestedTools = default;
            if (discriminator?.Type == global::G.WorkflowToolResponseModelInputStepDiscriminatorType.NestedTools)
            {
                nestedTools = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowToolNestedToolsStepModelInput>(ref reader, options);
            }
            global::G.WorkflowToolMaxIterationsExceededStepModel? maxIterationsExceeded = default;
            if (discriminator?.Type == global::G.WorkflowToolResponseModelInputStepDiscriminatorType.MaxIterationsExceeded)
            {
                maxIterationsExceeded = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowToolMaxIterationsExceededStepModel>(ref reader, options);
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

            if (value.IsEdge)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Edge, typeof(global::G.WorkflowToolEdgeStepModel), options);
            }
            else if (value.IsNestedTools)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NestedTools, typeof(global::G.WorkflowToolNestedToolsStepModelInput), options);
            }
            else if (value.IsMaxIterationsExceeded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxIterationsExceeded, typeof(global::G.WorkflowToolMaxIterationsExceededStepModel), options);
            }
        }
    }
}