//HintName: G.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSizeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSizeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize?>
    {
        /// <inheritdoc />
        public override global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize? existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSizeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSizeExtensions.ToValueString(value.Value));
            }
        }
    }
}
