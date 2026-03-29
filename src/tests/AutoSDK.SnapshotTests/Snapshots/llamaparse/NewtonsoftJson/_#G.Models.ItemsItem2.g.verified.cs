//HintName: G.Models.ItemsItem2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ItemsItem2 : global::System.IEquatable<ItemsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.HeaderItemItemDiscriminatorType? Type { get; }

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
        public static implicit operator ItemsItem2(global::G.TextItem value) => new ItemsItem2((global::G.TextItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextItem?(ItemsItem2 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem2(global::G.TextItem? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem2(global::G.HeadingItem value) => new ItemsItem2((global::G.HeadingItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HeadingItem?(ItemsItem2 @this) => @this.Heading;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem2(global::G.HeadingItem? value)
        {
            Heading = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem2(global::G.ListItem value) => new ItemsItem2((global::G.ListItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ListItem?(ItemsItem2 @this) => @this.List;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem2(global::G.ListItem? value)
        {
            List = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem2(global::G.CodeItem value) => new ItemsItem2((global::G.CodeItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeItem?(ItemsItem2 @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem2(global::G.CodeItem? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem2(global::G.TableItem value) => new ItemsItem2((global::G.TableItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TableItem?(ItemsItem2 @this) => @this.Table;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem2(global::G.TableItem? value)
        {
            Table = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem2(global::G.ImageItem value) => new ItemsItem2((global::G.ImageItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageItem?(ItemsItem2 @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem2(global::G.ImageItem? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem2(global::G.LinkItem value) => new ItemsItem2((global::G.LinkItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LinkItem?(ItemsItem2 @this) => @this.Link;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem2(global::G.LinkItem? value)
        {
            Link = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem2(
            global::G.HeaderItemItemDiscriminatorType? type,
            global::G.TextItem? text,
            global::G.HeadingItem? heading,
            global::G.ListItem? list,
            global::G.CodeItem? code,
            global::G.TableItem? table,
            global::G.ImageItem? image,
            global::G.LinkItem? link
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
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            Link?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsHeading && !IsList && !IsCode && !IsTable && !IsImage && !IsLink || !IsText && IsHeading && !IsList && !IsCode && !IsTable && !IsImage && !IsLink || !IsText && !IsHeading && IsList && !IsCode && !IsTable && !IsImage && !IsLink || !IsText && !IsHeading && !IsList && IsCode && !IsTable && !IsImage && !IsLink || !IsText && !IsHeading && !IsList && !IsCode && IsTable && !IsImage && !IsLink || !IsText && !IsHeading && !IsList && !IsCode && !IsTable && IsImage && !IsLink || !IsText && !IsHeading && !IsList && !IsCode && !IsTable && !IsImage && IsLink;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextItem?, TResult>? text = null,
            global::System.Func<global::G.HeadingItem?, TResult>? heading = null,
            global::System.Func<global::G.ListItem?, TResult>? list = null,
            global::System.Func<global::G.CodeItem?, TResult>? code = null,
            global::System.Func<global::G.TableItem?, TResult>? table = null,
            global::System.Func<global::G.ImageItem?, TResult>? image = null,
            global::System.Func<global::G.LinkItem?, TResult>? link = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsHeading && heading != null)
            {
                return heading(Heading!);
            }
            else if (IsList && list != null)
            {
                return list(List!);
            }
            else if (IsCode && code != null)
            {
                return code(Code!);
            }
            else if (IsTable && table != null)
            {
                return table(Table!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsLink && link != null)
            {
                return link(Link!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextItem?>? text = null,
            global::System.Action<global::G.HeadingItem?>? heading = null,
            global::System.Action<global::G.ListItem?>? list = null,
            global::System.Action<global::G.CodeItem?>? code = null,
            global::System.Action<global::G.TableItem?>? table = null,
            global::System.Action<global::G.ImageItem?>? image = null,
            global::System.Action<global::G.LinkItem?>? link = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsHeading)
            {
                heading?.Invoke(Heading!);
            }
            else if (IsList)
            {
                list?.Invoke(List!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsTable)
            {
                table?.Invoke(Table!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsLink)
            {
                link?.Invoke(Link!);
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
        public bool Equals(ItemsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextItem?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HeadingItem?>.Default.Equals(Heading, other.Heading) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ListItem?>.Default.Equals(List, other.List) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeItem?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TableItem?>.Default.Equals(Table, other.Table) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageItem?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LinkItem?>.Default.Equals(Link, other.Link) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ItemsItem2 obj1, ItemsItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ItemsItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ItemsItem2 obj1, ItemsItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ItemsItem2 o && Equals(o);
        }
    }
}
