//HintName: G.JsonConverters.MaybeExpandedComment.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MaybeExpandedCommentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MaybeExpandedComment>
    {
        /// <inheritdoc />
        public override global::G.MaybeExpandedComment Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("annotation")) __score0++;
            if (__jsonProps.Contains("classifications")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("created_by")) __score0++;
            if (__jsonProps.Contains("draft")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("is_resolved")) __score0++;
            if (__jsonProps.Contains("project")) __score0++;
            if (__jsonProps.Contains("region_ref")) __score0++;
            if (__jsonProps.Contains("resolved_at")) __score0++;
            if (__jsonProps.Contains("state")) __score0++;
            if (__jsonProps.Contains("task")) __score0++;
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("updated_at")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("annotation")) __score1++;
            if (__jsonProps.Contains("classifications")) __score1++;
            if (__jsonProps.Contains("created_at")) __score1++;
            if (__jsonProps.Contains("created_by")) __score1++;
            if (__jsonProps.Contains("draft")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("is_resolved")) __score1++;
            if (__jsonProps.Contains("project")) __score1++;
            if (__jsonProps.Contains("region_ref")) __score1++;
            if (__jsonProps.Contains("resolved_at")) __score1++;
            if (__jsonProps.Contains("state")) __score1++;
            if (__jsonProps.Contains("task")) __score1++;
            if (__jsonProps.Contains("text")) __score1++;
            if (__jsonProps.Contains("updated_at")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.Comment? comment = default;
            global::G.CommentSerializerWithExpandedUser? serializerWithUser = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        comment = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Comment>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        serializerWithUser = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CommentSerializerWithExpandedUser>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (comment == null && serializerWithUser == null)
            {
                try
                {
                    comment = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Comment>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    serializerWithUser = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CommentSerializerWithExpandedUser>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MaybeExpandedComment(
                comment,

                serializerWithUser
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MaybeExpandedComment value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsComment)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Comment, typeof(global::G.Comment), options);
            }
            else if (value.IsSerializerWithUser)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SerializerWithUser, typeof(global::G.CommentSerializerWithExpandedUser), options);
            }
        }
    }
}