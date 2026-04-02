//HintName: G.JsonConverters.AnimationError.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AnimationErrorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AnimationError>
    {
        /// <inheritdoc />
        public override global::G.AnimationError Read(
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
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("kind")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("description")) __score1++;
            if (__jsonProps.Contains("kind")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("description")) __score2++;
            if (__jsonProps.Contains("kind")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("description")) __score3++;
            if (__jsonProps.Contains("kind")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("description")) __score4++;
            if (__jsonProps.Contains("kind")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("description")) __score5++;
            if (__jsonProps.Contains("kind")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::G.AnimationErrorVariant1? animationErrorVariant1 = default;
            global::G.AnimationErrorVariant2? animationErrorVariant2 = default;
            global::G.AnimationErrorVariant3? animationErrorVariant3 = default;
            global::G.AnimationErrorVariant4? animationErrorVariant4 = default;
            global::G.AnimationErrorVariant5? animationErrorVariant5 = default;
            global::G.AnimationErrorVariant6? animationErrorVariant6 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        animationErrorVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnimationErrorVariant1>(__rawJson, options);
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
                        animationErrorVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnimationErrorVariant2>(__rawJson, options);
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
                        animationErrorVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnimationErrorVariant3>(__rawJson, options);
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
                        animationErrorVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnimationErrorVariant4>(__rawJson, options);
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
                        animationErrorVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnimationErrorVariant5>(__rawJson, options);
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
                        animationErrorVariant6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnimationErrorVariant6>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (animationErrorVariant1 == null && animationErrorVariant2 == null && animationErrorVariant3 == null && animationErrorVariant4 == null && animationErrorVariant5 == null && animationErrorVariant6 == null)
            {
                try
                {
                    animationErrorVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnimationErrorVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    animationErrorVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnimationErrorVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    animationErrorVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnimationErrorVariant3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    animationErrorVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnimationErrorVariant4>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    animationErrorVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnimationErrorVariant5>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    animationErrorVariant6 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnimationErrorVariant6>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.AnimationError(
                animationErrorVariant1,

                animationErrorVariant2,

                animationErrorVariant3,

                animationErrorVariant4,

                animationErrorVariant5,

                animationErrorVariant6
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AnimationError value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAnimationErrorVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnimationErrorVariant1, typeof(global::G.AnimationErrorVariant1), options);
            }
            else if (value.IsAnimationErrorVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnimationErrorVariant2, typeof(global::G.AnimationErrorVariant2), options);
            }
            else if (value.IsAnimationErrorVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnimationErrorVariant3, typeof(global::G.AnimationErrorVariant3), options);
            }
            else if (value.IsAnimationErrorVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnimationErrorVariant4, typeof(global::G.AnimationErrorVariant4), options);
            }
            else if (value.IsAnimationErrorVariant5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnimationErrorVariant5, typeof(global::G.AnimationErrorVariant5), options);
            }
            else if (value.IsAnimationErrorVariant6)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnimationErrorVariant6, typeof(global::G.AnimationErrorVariant6), options);
            }
        }
    }
}