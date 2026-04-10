//HintName: G.JsonConverters.FilterNumberTypeColumnOnCallTableColumn.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FilterNumberTypeColumnOnCallTableColumnJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.FilterNumberTypeColumnOnCallTableColumn>
    {
        /// <inheritdoc />
        public override global::G.FilterNumberTypeColumnOnCallTableColumn ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.FilterNumberTypeColumnOnCallTableColumn existingValue,
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
                        return global::G.FilterNumberTypeColumnOnCallTableColumnExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.FilterNumberTypeColumnOnCallTableColumn)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.FilterNumberTypeColumnOnCallTableColumn);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.FilterNumberTypeColumnOnCallTableColumn value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.FilterNumberTypeColumnOnCallTableColumnExtensions.ToValueString(value));
        }
    }
}
