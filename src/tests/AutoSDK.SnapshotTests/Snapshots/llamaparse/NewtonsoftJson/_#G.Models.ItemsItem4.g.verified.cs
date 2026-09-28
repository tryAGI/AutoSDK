//HintName: G.Models.ItemsItem4.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ItemsItem4 : global::System.IEquatable<ItemsItem4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.StructuredResultPageItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextItem? Text { get; init; }
#else
        public global::G.TextItem? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.TextItem? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.TextItem PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.HeadingItem? Heading { get; init; }
#else
        public global::G.HeadingItem? Heading { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Heading))]
#endif
        public bool IsHeading => Heading != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHeading(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.HeadingItem? value)
        {
            value = Heading;
            return IsHeading;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.HeadingItem PickHeading() => Heading is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Heading' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ListItem? List { get; init; }
#else
        public global::G.ListItem? List { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(List))]
#endif
        public bool IsList => List != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickList(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ListItem? value)
        {
            value = List;
            return IsList;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ListItem PickList() => List is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'List' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeItem? Code { get; init; }
#else
        public global::G.CodeItem? Code { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Code))]
#endif
        public bool IsCode => Code != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CodeItem? value)
        {
            value = Code;
            return IsCode;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CodeItem PickCode() => Code is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Code' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TableItem? Table { get; init; }
#else
        public global::G.TableItem? Table { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Table))]
#endif
        public bool IsTable => Table != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.TableItem? value)
        {
            value = Table;
            return IsTable;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.TableItem PickTable() => Table is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Table' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageItem? Image { get; init; }
#else
        public global::G.ImageItem? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ImageItem? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ImageItem PickImage() => Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LinkItem? Link { get; init; }
#else
        public global::G.LinkItem? Link { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Link))]
#endif
        public bool IsLink => Link != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLink(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.LinkItem? value)
        {
            value = Link;
            return IsLink;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.LinkItem PickLink() => Link is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Link' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.HeaderItem? Header { get; init; }
#else
        public global::G.HeaderItem? Header { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Header))]
#endif
        public bool IsHeader => Header != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHeader(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.HeaderItem? value)
        {
            value = Header;
            return IsHeader;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.HeaderItem PickHeader() => Header is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Header' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FooterItem? Footer { get; init; }
#else
        public global::G.FooterItem? Footer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Footer))]
#endif
        public bool IsFooter => Footer != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFooter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.FooterItem? value)
        {
            value = Footer;
            return IsFooter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.FooterItem PickFooter() => Footer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Footer' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem4(global::G.TextItem value) => new ItemsItem4((global::G.TextItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextItem?(ItemsItem4 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem4(global::G.TextItem? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem4 FromText(global::G.TextItem? value) => new ItemsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem4(global::G.HeadingItem value) => new ItemsItem4((global::G.HeadingItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HeadingItem?(ItemsItem4 @this) => @this.Heading;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem4(global::G.HeadingItem? value)
        {
            Heading = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem4 FromHeading(global::G.HeadingItem? value) => new ItemsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem4(global::G.ListItem value) => new ItemsItem4((global::G.ListItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ListItem?(ItemsItem4 @this) => @this.List;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem4(global::G.ListItem? value)
        {
            List = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem4 FromList(global::G.ListItem? value) => new ItemsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem4(global::G.CodeItem value) => new ItemsItem4((global::G.CodeItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeItem?(ItemsItem4 @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem4(global::G.CodeItem? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem4 FromCode(global::G.CodeItem? value) => new ItemsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem4(global::G.TableItem value) => new ItemsItem4((global::G.TableItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TableItem?(ItemsItem4 @this) => @this.Table;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem4(global::G.TableItem? value)
        {
            Table = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem4 FromTable(global::G.TableItem? value) => new ItemsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem4(global::G.ImageItem value) => new ItemsItem4((global::G.ImageItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageItem?(ItemsItem4 @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem4(global::G.ImageItem? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem4 FromImage(global::G.ImageItem? value) => new ItemsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem4(global::G.LinkItem value) => new ItemsItem4((global::G.LinkItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LinkItem?(ItemsItem4 @this) => @this.Link;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem4(global::G.LinkItem? value)
        {
            Link = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem4 FromLink(global::G.LinkItem? value) => new ItemsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem4(global::G.HeaderItem value) => new ItemsItem4((global::G.HeaderItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HeaderItem?(ItemsItem4 @this) => @this.Header;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem4(global::G.HeaderItem? value)
        {
            Header = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem4 FromHeader(global::G.HeaderItem? value) => new ItemsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem4(global::G.FooterItem value) => new ItemsItem4((global::G.FooterItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FooterItem?(ItemsItem4 @this) => @this.Footer;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem4(global::G.FooterItem? value)
        {
            Footer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem4 FromFooter(global::G.FooterItem? value) => new ItemsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem4(
            global::G.StructuredResultPageItemDiscriminatorType? type,
            global::G.TextItem? text,
            global::G.HeadingItem? heading,
            global::G.ListItem? list,
            global::G.CodeItem? code,
            global::G.TableItem? table,
            global::G.ImageItem? image,
            global::G.LinkItem? link,
            global::G.HeaderItem? header,
            global::G.FooterItem? footer
            )
        {
            Type = type;

            Text = text;
            Heading = heading;
            List = list;
            Code = code;
            Table = table;
            Image = image;
            Link = link;
            Header = header;
            Footer = footer;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Footer as object ??
            Header as object ??
            Link as object ??
            Image as object ??
            Table as object ??
            Code as object ??
            List as object ??
            Heading as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Heading?.ToString() ??
            List?.ToString() ??
            Code?.ToString() ??
            Table?.ToString() ??
            Image?.ToString() ??
            Link?.ToString() ??
            Header?.ToString() ??
            Footer?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsHeading && !IsList && !IsCode && !IsTable && !IsImage && !IsLink && !IsHeader && !IsFooter || !IsText && IsHeading && !IsList && !IsCode && !IsTable && !IsImage && !IsLink && !IsHeader && !IsFooter || !IsText && !IsHeading && IsList && !IsCode && !IsTable && !IsImage && !IsLink && !IsHeader && !IsFooter || !IsText && !IsHeading && !IsList && IsCode && !IsTable && !IsImage && !IsLink && !IsHeader && !IsFooter || !IsText && !IsHeading && !IsList && !IsCode && IsTable && !IsImage && !IsLink && !IsHeader && !IsFooter || !IsText && !IsHeading && !IsList && !IsCode && !IsTable && IsImage && !IsLink && !IsHeader && !IsFooter || !IsText && !IsHeading && !IsList && !IsCode && !IsTable && !IsImage && IsLink && !IsHeader && !IsFooter || !IsText && !IsHeading && !IsList && !IsCode && !IsTable && !IsImage && !IsLink && IsHeader && !IsFooter || !IsText && !IsHeading && !IsList && !IsCode && !IsTable && !IsImage && !IsLink && !IsHeader && IsFooter;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextItem, TResult>? text = null,
            global::System.Func<global::G.HeadingItem, TResult>? heading = null,
            global::System.Func<global::G.ListItem, TResult>? list = null,
            global::System.Func<global::G.CodeItem, TResult>? code = null,
            global::System.Func<global::G.TableItem, TResult>? table = null,
            global::System.Func<global::G.ImageItem, TResult>? image = null,
            global::System.Func<global::G.LinkItem, TResult>? link = null,
            global::System.Func<global::G.HeaderItem, TResult>? header = null,
            global::System.Func<global::G.FooterItem, TResult>? footer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (Heading is { } __value1 && heading != null)
            {
                return heading(__value1);
            }
            else if (List is { } __value2 && list != null)
            {
                return list(__value2);
            }
            else if (Code is { } __value3 && code != null)
            {
                return code(__value3);
            }
            else if (Table is { } __value4 && table != null)
            {
                return table(__value4);
            }
            else if (Image is { } __value5 && image != null)
            {
                return image(__value5);
            }
            else if (Link is { } __value6 && link != null)
            {
                return link(__value6);
            }
            else if (Header is { } __value7 && header != null)
            {
                return header(__value7);
            }
            else if (Footer is { } __value8 && footer != null)
            {
                return footer(__value8);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextItem>? text = null,

            global::System.Action<global::G.HeadingItem>? heading = null,

            global::System.Action<global::G.ListItem>? list = null,

            global::System.Action<global::G.CodeItem>? code = null,

            global::System.Action<global::G.TableItem>? table = null,

            global::System.Action<global::G.ImageItem>? image = null,

            global::System.Action<global::G.LinkItem>? link = null,

            global::System.Action<global::G.HeaderItem>? header = null,

            global::System.Action<global::G.FooterItem>? footer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Heading is { } __value1)
            {
                heading?.Invoke(__value1);
            }
            else if (List is { } __value2)
            {
                list?.Invoke(__value2);
            }
            else if (Code is { } __value3)
            {
                code?.Invoke(__value3);
            }
            else if (Table is { } __value4)
            {
                table?.Invoke(__value4);
            }
            else if (Image is { } __value5)
            {
                image?.Invoke(__value5);
            }
            else if (Link is { } __value6)
            {
                link?.Invoke(__value6);
            }
            else if (Header is { } __value7)
            {
                header?.Invoke(__value7);
            }
            else if (Footer is { } __value8)
            {
                footer?.Invoke(__value8);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.TextItem>? text = null,
            global::System.Action<global::G.HeadingItem>? heading = null,
            global::System.Action<global::G.ListItem>? list = null,
            global::System.Action<global::G.CodeItem>? code = null,
            global::System.Action<global::G.TableItem>? table = null,
            global::System.Action<global::G.ImageItem>? image = null,
            global::System.Action<global::G.LinkItem>? link = null,
            global::System.Action<global::G.HeaderItem>? header = null,
            global::System.Action<global::G.FooterItem>? footer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Heading is { } __value1)
            {
                heading?.Invoke(__value1);
            }
            else if (List is { } __value2)
            {
                list?.Invoke(__value2);
            }
            else if (Code is { } __value3)
            {
                code?.Invoke(__value3);
            }
            else if (Table is { } __value4)
            {
                table?.Invoke(__value4);
            }
            else if (Image is { } __value5)
            {
                image?.Invoke(__value5);
            }
            else if (Link is { } __value6)
            {
                link?.Invoke(__value6);
            }
            else if (Header is { } __value7)
            {
                header?.Invoke(__value7);
            }
            else if (Footer is { } __value8)
            {
                footer?.Invoke(__value8);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::G.TextItem),
                Heading,
                typeof(global::G.HeadingItem),
                List,
                typeof(global::G.ListItem),
                Code,
                typeof(global::G.CodeItem),
                Table,
                typeof(global::G.TableItem),
                Image,
                typeof(global::G.ImageItem),
                Link,
                typeof(global::G.LinkItem),
                Header,
                typeof(global::G.HeaderItem),
                Footer,
                typeof(global::G.FooterItem),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ItemsItem4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextItem?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HeadingItem?>.Default.Equals(Heading, other.Heading) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ListItem?>.Default.Equals(List, other.List) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeItem?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TableItem?>.Default.Equals(Table, other.Table) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageItem?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LinkItem?>.Default.Equals(Link, other.Link) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HeaderItem?>.Default.Equals(Header, other.Header) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FooterItem?>.Default.Equals(Footer, other.Footer) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ItemsItem4 obj1, ItemsItem4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ItemsItem4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ItemsItem4 obj1, ItemsItem4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ItemsItem4 o && Equals(o);
        }
    }
}
