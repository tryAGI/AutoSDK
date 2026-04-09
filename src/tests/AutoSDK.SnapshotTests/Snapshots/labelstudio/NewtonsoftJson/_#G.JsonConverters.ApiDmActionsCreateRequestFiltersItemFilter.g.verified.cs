//HintName: G.JsonConverters.ApiDmActionsCreateRequestFiltersItemFilter.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiDmActionsCreateRequestFiltersItemFilterJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ApiDmActionsCreateRequestFiltersItemFilter>
    {
        /// <inheritdoc />
        public override global::G.ApiDmActionsCreateRequestFiltersItemFilter ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ApiDmActionsCreateRequestFiltersItemFilter existingValue,
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
                        return global::G.ApiDmActionsCreateRequestFiltersItemFilterExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ApiDmActionsCreateRequestFiltersItemFilter)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ApiDmActionsCreateRequestFiltersItemFilter);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ApiDmActionsCreateRequestFiltersItemFilter value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ApiDmActionsCreateRequestFiltersItemFilterExtensions.ToValueString(value));
        }
    }
}
