//HintName: G.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtensionJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension>
    {
        /// <inheritdoc />
        public override global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension existingValue,
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
                        return global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtensionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtensionExtensions.ToValueString(value));
        }
    }
}
