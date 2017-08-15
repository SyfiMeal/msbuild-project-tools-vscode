using System;
using System.Xml;

namespace MSBuildProjectTools.LanguageServer.XmlParser
{
    /// <summary>
    ///     Location information for an XML attribute.
    /// </summary>
    public class AttributeLocation
        : NodeLocation
    {
        /// <summary>
        ///     The text range containing the attribute's name.
        /// </summary>
        public Range NameRange { get; internal set; }

        /// <summary>
        ///     The starting position of the attribute name.
        /// </summary>
        public Position NameStart => NameRange?.Start;

        /// <summary>
        ///     The ending position of the attribute name.
        /// </summary>
        public Position NameEnd => NameRange?.End;

        /// <summary>
        ///     The text range containing the attribute's value.
        /// </summary>
        public Range ValueRange { get; internal set; }

        /// <summary>
        ///     The starting position of the attribute value.
        /// </summary>
        public Position ValueStart => ValueRange?.Start;

        /// <summary>
        ///     The ending position of the attribute value.
        /// </summary>
        public Position ValueEnd => ValueRange?.End;

        /// <summary>
        ///     Create an <see cref="AttributeLocation"/>, calculating values as required.
        /// </summary>
        /// <param name="start">
        ///     The attribute's starting position.
        /// </param>
        /// <param name="name">
        ///     The attribute name.
        /// </param>
        /// <param name="value">
        ///     The attribute value.
        /// </param>
        /// <returns>
        ///     The new <see cref="AttributeLocation"/>.
        /// </returns>
        public static AttributeLocation Create(Position start, string name, string value)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return new AttributeLocation
            {
                Range = new Range(
                    start: start,
                    end: start.Move(
                        columnCount: name.Length + 2 /* =" */ + value.Length + 1 /* " */
                    )
                ),
                NameRange = new Range(
                    start: start,
                    end: start.Move(
                        columnCount: name.Length
                    )
                ),
                ValueRange = new Range(
                    start: start.Move(
                        columnCount: name.Length + 2 /* =" */
                    ),
                    end: start.Move(
                        columnCount: name.Length + 2 /* =" */ + value.Length
                    )
                )
            };
        }
    }
}