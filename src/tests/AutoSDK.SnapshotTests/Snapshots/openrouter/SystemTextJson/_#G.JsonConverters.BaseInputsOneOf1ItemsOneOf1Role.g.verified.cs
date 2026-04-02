//HintName: G.JsonConverters.BaseInputsOneOf1ItemsOneOf1Role.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BaseInputsOneOf1ItemsOneOf1RoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseInputsOneOf1ItemsOneOf1Role>
    {
        /// <inheritdoc />
        public override global::G.BaseInputsOneOf1ItemsOneOf1Role Read(
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

            global::G.BaseInputsOneOf1ItemsOneOf1Role0? baseInputsOneOf1ItemsOneOf1Role0 = default;
            global::G.BaseInputsOneOf1ItemsOneOf1Role1? baseInputsOneOf1ItemsOneOf1Role1 = default;
            global::G.BaseInputsOneOf1ItemsOneOf1Role2? baseInputsOneOf1ItemsOneOf1Role2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        baseInputsOneOf1ItemsOneOf1Role0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseInputsOneOf1ItemsOneOf1Role0>(__rawJson, options);
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

                        baseInputsOneOf1ItemsOneOf1Role1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseInputsOneOf1ItemsOneOf1Role1>(__rawJson, options);
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

                        baseInputsOneOf1ItemsOneOf1Role2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseInputsOneOf1ItemsOneOf1Role2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (baseInputsOneOf1ItemsOneOf1Role0 == null && baseInputsOneOf1ItemsOneOf1Role1 == null && baseInputsOneOf1ItemsOneOf1Role2 == null)
            {
                try
                {

                    baseInputsOneOf1ItemsOneOf1Role0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseInputsOneOf1ItemsOneOf1Role0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    baseInputsOneOf1ItemsOneOf1Role1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseInputsOneOf1ItemsOneOf1Role1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    baseInputsOneOf1ItemsOneOf1Role2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.BaseInputsOneOf1ItemsOneOf1Role2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.BaseInputsOneOf1ItemsOneOf1Role(
                baseInputsOneOf1ItemsOneOf1Role0,

                baseInputsOneOf1ItemsOneOf1Role1,

                baseInputsOneOf1ItemsOneOf1Role2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseInputsOneOf1ItemsOneOf1Role value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBaseInputsOneOf1ItemsOneOf1Role0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseInputsOneOf1ItemsOneOf1Role0, typeof(global::G.BaseInputsOneOf1ItemsOneOf1Role0), options);
            }
            else if (value.IsBaseInputsOneOf1ItemsOneOf1Role1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseInputsOneOf1ItemsOneOf1Role1, typeof(global::G.BaseInputsOneOf1ItemsOneOf1Role1), options);
            }
            else if (value.IsBaseInputsOneOf1ItemsOneOf1Role2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseInputsOneOf1ItemsOneOf1Role2, typeof(global::G.BaseInputsOneOf1ItemsOneOf1Role2), options);
            }
        }
    }
}