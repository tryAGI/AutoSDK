//HintName: G.JsonConverters.EasyInputMessageRole.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EasyInputMessageRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EasyInputMessageRole>
    {
        /// <inheritdoc />
        public override global::G.EasyInputMessageRole Read(
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
            var __score3 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.EasyInputMessageRole0? easyInputMessageRole0 = default;
            global::G.EasyInputMessageRole1? easyInputMessageRole1 = default;
            global::G.EasyInputMessageRole2? easyInputMessageRole2 = default;
            global::G.EasyInputMessageRole3? easyInputMessageRole3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        easyInputMessageRole0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessageRole0>(__rawJson, options);
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

                        easyInputMessageRole1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessageRole1>(__rawJson, options);
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

                        easyInputMessageRole2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessageRole2>(__rawJson, options);
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

                        easyInputMessageRole3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessageRole3>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (easyInputMessageRole0 == null && easyInputMessageRole1 == null && easyInputMessageRole2 == null && easyInputMessageRole3 == null)
            {
                try
                {

                    easyInputMessageRole0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessageRole0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    easyInputMessageRole1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessageRole1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    easyInputMessageRole2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessageRole2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    easyInputMessageRole3 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.EasyInputMessageRole3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.EasyInputMessageRole(
                easyInputMessageRole0,

                easyInputMessageRole1,

                easyInputMessageRole2,

                easyInputMessageRole3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EasyInputMessageRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEasyInputMessageRole0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyInputMessageRole0, typeof(global::G.EasyInputMessageRole0), options);
            }
            else if (value.IsEasyInputMessageRole1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyInputMessageRole1, typeof(global::G.EasyInputMessageRole1), options);
            }
            else if (value.IsEasyInputMessageRole2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyInputMessageRole2, typeof(global::G.EasyInputMessageRole2), options);
            }
            else if (value.IsEasyInputMessageRole3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyInputMessageRole3, typeof(global::G.EasyInputMessageRole3), options);
            }
        }
    }
}