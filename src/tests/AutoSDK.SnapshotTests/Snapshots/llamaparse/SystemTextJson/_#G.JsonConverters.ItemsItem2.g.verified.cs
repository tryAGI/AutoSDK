//HintName: G.JsonConverters.ItemsItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ItemsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ItemsItem2>
    {
        /// <inheritdoc />
        public override global::G.ItemsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.HeaderItemItemDiscriminator>(ref readerCopy, options);

            global::G.TextItem? text = default;
            if (discriminator?.Type == global::G.HeaderItemItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextItem>(ref reader, options);
            }
            global::G.HeadingItem? heading = default;
            if (discriminator?.Type == global::G.HeaderItemItemDiscriminatorType.Heading)
            {
                heading = global::System.Text.Json.JsonSerializer.Deserialize<global::G.HeadingItem>(ref reader, options);
            }
            global::G.ListItem? list = default;
            if (discriminator?.Type == global::G.HeaderItemItemDiscriminatorType.List)
            {
                list = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListItem>(ref reader, options);
            }
            global::G.CodeItem? code = default;
            if (discriminator?.Type == global::G.HeaderItemItemDiscriminatorType.Code)
            {
                code = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeItem>(ref reader, options);
            }
            global::G.TableItem? table = default;
            if (discriminator?.Type == global::G.HeaderItemItemDiscriminatorType.Table)
            {
                table = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TableItem>(ref reader, options);
            }
            global::G.ImageItem? image = default;
            if (discriminator?.Type == global::G.HeaderItemItemDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageItem>(ref reader, options);
            }
            global::G.LinkItem? link = default;
            if (discriminator?.Type == global::G.HeaderItemItemDiscriminatorType.Link)
            {
                link = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LinkItem>(ref reader, options);
            }

            var __value = new global::G.ItemsItem2(
                discriminator?.Type,
                text,

                heading,

                list,

                code,

                table,

                image,

                link
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ItemsItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::G.TextItem), options);
            }
            else if (value.IsHeading)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Heading, typeof(global::G.HeadingItem), options);
            }
            else if (value.IsList)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.List, typeof(global::G.ListItem), options);
            }
            else if (value.IsCode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeof(global::G.CodeItem), options);
            }
            else if (value.IsTable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Table, typeof(global::G.TableItem), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::G.ImageItem), options);
            }
            else if (value.IsLink)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Link, typeof(global::G.LinkItem), options);
            }
        }
    }
}