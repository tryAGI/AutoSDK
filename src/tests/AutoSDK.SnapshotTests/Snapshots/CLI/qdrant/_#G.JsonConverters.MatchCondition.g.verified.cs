//HintName: G.JsonConverters.MatchCondition.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MatchConditionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MatchCondition>
    {
        /// <inheritdoc />
        public override global::G.MatchCondition Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

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
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("text")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("text_any")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("phrase")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("any")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("except")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::G.MatchValue? value = default;
            global::G.MatchText? text = default;
            global::G.MatchTextAny? textAny = default;
            global::G.MatchPhrase? phrase = default;
            global::G.MatchAny? any = default;
            global::G.MatchExcept? except = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchValue).Name}");
                        value = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchText> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchText).Name}");
                        text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchTextAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchTextAny> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchTextAny).Name}");
                        textAny = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchPhrase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchPhrase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchPhrase).Name}");
                        phrase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchAny> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchAny).Name}");
                        any = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchExcept), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchExcept> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchExcept).Name}");
                        except = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value == null && text == null && textAny == null && phrase == null && any == null && except == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchValue).Name}");
                    value = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchText> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchText).Name}");
                    text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchTextAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchTextAny> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchTextAny).Name}");
                    textAny = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchPhrase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchPhrase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchPhrase).Name}");
                    phrase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchAny> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchAny).Name}");
                    any = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchExcept), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchExcept> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchExcept).Name}");
                    except = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.MatchCondition(
                value,

                text,

                textAny,

                phrase,

                any,

                except
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MatchCondition value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsTextAny)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchTextAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchTextAny?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchTextAny).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextAny!, typeInfo);
            }
            else if (value.IsPhrase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchPhrase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchPhrase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchPhrase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Phrase!, typeInfo);
            }
            else if (value.IsAny)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchAny?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchAny).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Any!, typeInfo);
            }
            else if (value.IsExcept)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MatchExcept), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MatchExcept?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MatchExcept).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Except!, typeInfo);
            }
        }
    }
}