//HintName: G.JsonConverters.UserGivenName.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class UserGivenNameJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UserGivenName>
    {
        /// <inheritdoc />
        public override global::G.UserGivenName Read(
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            string? userGivenNameVariant1 = default;
            global::System.Collections.Generic.IList<string>? userGivenNameVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        userGivenNameVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        userGivenNameVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<string>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (userGivenNameVariant1 == null && userGivenNameVariant2 == null)
            {
                try
                {

                    userGivenNameVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    userGivenNameVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<string>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.UserGivenName(
                userGivenNameVariant1,

                userGivenNameVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UserGivenName value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsUserGivenNameVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserGivenNameVariant1, typeof(string), options);
            }
            else if (value.IsUserGivenNameVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserGivenNameVariant2, typeof(global::System.Collections.Generic.IList<string>), options);
            }
        }
    }
}