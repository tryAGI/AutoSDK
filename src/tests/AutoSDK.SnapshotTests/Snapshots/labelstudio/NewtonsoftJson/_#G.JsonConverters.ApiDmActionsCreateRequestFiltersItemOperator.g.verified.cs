//HintName: G.JsonConverters.ApiDmActionsCreateRequestFiltersItemOperator.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiDmActionsCreateRequestFiltersItemOperatorJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ApiDmActionsCreateRequestFiltersItemOperator>
    {
        /// <inheritdoc />
        public override global::G.ApiDmActionsCreateRequestFiltersItemOperator ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ApiDmActionsCreateRequestFiltersItemOperator existingValue,
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
                        return global::G.ApiDmActionsCreateRequestFiltersItemOperatorExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ApiDmActionsCreateRequestFiltersItemOperator)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ApiDmActionsCreateRequestFiltersItemOperator);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ApiDmActionsCreateRequestFiltersItemOperator value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ApiDmActionsCreateRequestFiltersItemOperatorExtensions.ToValueString(value));
        }
    }
}
