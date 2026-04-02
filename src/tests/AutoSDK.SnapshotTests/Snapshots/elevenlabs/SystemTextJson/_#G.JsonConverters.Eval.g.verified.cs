//HintName: G.JsonConverters.Eval.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EvalJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Eval>
    {
        /// <inheritdoc />
        public override global::G.Eval Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UnitTestToolCallParameterEvalDiscriminator>(ref readerCopy, options);

            global::G.LLMParameterEvaluationStrategy? llm = default;
            if (discriminator?.Type == global::G.UnitTestToolCallParameterEvalDiscriminatorType.Llm)
            {
                llm = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LLMParameterEvaluationStrategy>(ref reader, options);
            }
            global::G.RegexParameterEvaluationStrategy? regex = default;
            if (discriminator?.Type == global::G.UnitTestToolCallParameterEvalDiscriminatorType.Regex)
            {
                regex = global::System.Text.Json.JsonSerializer.Deserialize<global::G.RegexParameterEvaluationStrategy>(ref reader, options);
            }
            global::G.ExactParameterEvaluationStrategy? exact = default;
            if (discriminator?.Type == global::G.UnitTestToolCallParameterEvalDiscriminatorType.Exact)
            {
                exact = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExactParameterEvaluationStrategy>(ref reader, options);
            }
            global::G.MatchAnythingParameterEvaluationStrategy? anything = default;
            if (discriminator?.Type == global::G.UnitTestToolCallParameterEvalDiscriminatorType.Anything)
            {
                anything = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MatchAnythingParameterEvaluationStrategy>(ref reader, options);
            }

            var __value = new global::G.Eval(
                discriminator?.Type,
                llm,

                regex,

                exact,

                anything
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Eval value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeof(global::G.LLMParameterEvaluationStrategy), options);
            }
            else if (value.IsRegex)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Regex, typeof(global::G.RegexParameterEvaluationStrategy), options);
            }
            else if (value.IsExact)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Exact, typeof(global::G.ExactParameterEvaluationStrategy), options);
            }
            else if (value.IsAnything)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anything, typeof(global::G.MatchAnythingParameterEvaluationStrategy), options);
            }
        }
    }
}