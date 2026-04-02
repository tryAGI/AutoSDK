//HintName: G.JsonConverters.OutputMessageStatus.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OutputMessageStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OutputMessageStatus>
    {
        /// <inheritdoc />
        public override global::G.OutputMessageStatus Read(
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

            global::G.OutputMessageStatus0? outputMessageStatus0 = default;
            global::G.OutputMessageStatus1? outputMessageStatus1 = default;
            global::G.OutputMessageStatus2? outputMessageStatus2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        outputMessageStatus0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessageStatus0>(__rawJson, options);
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

                        outputMessageStatus1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessageStatus1>(__rawJson, options);
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

                        outputMessageStatus2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessageStatus2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (outputMessageStatus0 == null && outputMessageStatus1 == null && outputMessageStatus2 == null)
            {
                try
                {

                    outputMessageStatus0 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessageStatus0>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    outputMessageStatus1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessageStatus1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    outputMessageStatus2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.OutputMessageStatus2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.OutputMessageStatus(
                outputMessageStatus0,

                outputMessageStatus1,

                outputMessageStatus2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OutputMessageStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOutputMessageStatus0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessageStatus0, typeof(global::G.OutputMessageStatus0), options);
            }
            else if (value.IsOutputMessageStatus1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessageStatus1, typeof(global::G.OutputMessageStatus1), options);
            }
            else if (value.IsOutputMessageStatus2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessageStatus2, typeof(global::G.OutputMessageStatus2), options);
            }
        }
    }
}