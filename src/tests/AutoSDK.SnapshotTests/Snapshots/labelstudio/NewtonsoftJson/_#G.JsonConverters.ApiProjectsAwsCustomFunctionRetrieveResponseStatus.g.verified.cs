//HintName: G.JsonConverters.ApiProjectsAwsCustomFunctionRetrieveResponseStatus.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiProjectsAwsCustomFunctionRetrieveResponseStatusJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ApiProjectsAwsCustomFunctionRetrieveResponseStatus>
    {
        /// <inheritdoc />
        public override global::G.ApiProjectsAwsCustomFunctionRetrieveResponseStatus ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ApiProjectsAwsCustomFunctionRetrieveResponseStatus existingValue,
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
                        return global::G.ApiProjectsAwsCustomFunctionRetrieveResponseStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ApiProjectsAwsCustomFunctionRetrieveResponseStatus)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ApiProjectsAwsCustomFunctionRetrieveResponseStatus);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ApiProjectsAwsCustomFunctionRetrieveResponseStatus value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ApiProjectsAwsCustomFunctionRetrieveResponseStatusExtensions.ToValueString(value));
        }
    }
}
