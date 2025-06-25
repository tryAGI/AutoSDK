﻿//HintName: G.JsonConverters.LemurResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class LemurResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LemurResponse>
    {
        /// <inheritdoc />
        public override global::G.LemurResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.LemurStringResponse? @string = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LemurStringResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LemurStringResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LemurStringResponse).Name}");
                @string = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.LemurQuestionAnswerResponse? questionAnswer = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LemurQuestionAnswerResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LemurQuestionAnswerResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LemurQuestionAnswerResponse).Name}");
                questionAnswer = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.LemurResponse(
                @string,
                questionAnswer
                );

            if (@string != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LemurStringResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LemurStringResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LemurStringResponse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (questionAnswer != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LemurQuestionAnswerResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LemurQuestionAnswerResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LemurQuestionAnswerResponse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LemurResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LemurStringResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LemurStringResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LemurStringResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.String, typeInfo);
            }
            else if (value.IsQuestionAnswer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LemurQuestionAnswerResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LemurQuestionAnswerResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LemurQuestionAnswerResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QuestionAnswer, typeInfo);
            }
        }
    }
}