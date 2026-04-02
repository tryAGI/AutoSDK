//HintName: G.JsonConverters.InputMessageItemRole.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InputMessageItemRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InputMessageItemRole>
    {
        /// <inheritdoc />
        public override global::G.InputMessageItemRole Read(
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
            var __score1 = 0;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.InputMessageItemRole0? inputMessageItemRole0 = default;
            global::G.InputMessageItemRole1? inputMessageItemRole1 = default;
            global::G.InputMessageItemRole2? inputMessageItemRole2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        inputMessageItemRole0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputMessageItemRole0>(__rawJson, options);
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

                        inputMessageItemRole1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputMessageItemRole1>(__rawJson, options);
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

                        inputMessageItemRole2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputMessageItemRole2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (inputMessageItemRole0 == null && inputMessageItemRole1 == null && inputMessageItemRole2 == null)
            {
                try
                {

                    inputMessageItemRole0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputMessageItemRole0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    inputMessageItemRole1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputMessageItemRole1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    inputMessageItemRole2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.InputMessageItemRole2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.InputMessageItemRole(
                inputMessageItemRole0,

                inputMessageItemRole1,

                inputMessageItemRole2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InputMessageItemRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInputMessageItemRole0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessageItemRole0, typeof(global::G.InputMessageItemRole0), options);
            }
            else if (value.IsInputMessageItemRole1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessageItemRole1, typeof(global::G.InputMessageItemRole1), options);
            }
            else if (value.IsInputMessageItemRole2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessageItemRole2, typeof(global::G.InputMessageItemRole2), options);
            }
        }
    }
}