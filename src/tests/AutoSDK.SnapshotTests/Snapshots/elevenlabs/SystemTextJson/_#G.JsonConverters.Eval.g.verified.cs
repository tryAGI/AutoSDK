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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UnitTestToolCallParameterEvalDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UnitTestToolCallParameterEvalDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UnitTestToolCallParameterEvalDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.LLMParameterEvaluationStrategy? llm = default;
            if (discriminator?.Type == global::G.UnitTestToolCallParameterEvalDiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMParameterEvaluationStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMParameterEvaluationStrategy> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LLMParameterEvaluationStrategy)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RegexParameterEvaluationStrategy? regex = default;
            if (discriminator?.Type == global::G.UnitTestToolCallParameterEvalDiscriminatorType.Regex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RegexParameterEvaluationStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RegexParameterEvaluationStrategy> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RegexParameterEvaluationStrategy)}");
                regex = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ExactParameterEvaluationStrategy? exact = default;
            if (discriminator?.Type == global::G.UnitTestToolCallParameterEvalDiscriminatorType.Exact)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExactParameterEvaluationStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExactParameterEvaluationStrategy> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ExactParameterEvaluationStrategy)}");
                exact = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MatchAnythingParameterEvaluationStrategy? anything = default;
            if (discriminator?.Type == global::G.UnitTestToolCallParameterEvalDiscriminatorType.Anything)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchAnythingParameterEvaluationStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchAnythingParameterEvaluationStrategy> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MatchAnythingParameterEvaluationStrategy)}");
                anything = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LLMParameterEvaluationStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LLMParameterEvaluationStrategy?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LLMParameterEvaluationStrategy).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeInfo);
            }
            else if (value.IsRegex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RegexParameterEvaluationStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RegexParameterEvaluationStrategy?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RegexParameterEvaluationStrategy).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Regex, typeInfo);
            }
            else if (value.IsExact)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExactParameterEvaluationStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExactParameterEvaluationStrategy?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExactParameterEvaluationStrategy).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Exact, typeInfo);
            }
            else if (value.IsAnything)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchAnythingParameterEvaluationStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchAnythingParameterEvaluationStrategy?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchAnythingParameterEvaluationStrategy).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anything, typeInfo);
            }
        }
    }
}