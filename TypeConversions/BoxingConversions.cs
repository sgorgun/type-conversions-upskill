using System;
using TypeConversions.TypesForConversions;

namespace TypeConversions
{
    public static class BoxingConversions
    {
        /// <summary>
        /// Performs an boxing conversion custom <see cref="Point"/> struct to <see cref="System.Object"/> class.
        /// </summary>
        /// <param name="point"><see cref="Point"/> object.</param>
        /// <returns><see cref="System.Object"/> object.</returns>
        public static object BoxToObject(Point point) => throw new NotImplementedException();

        /// <summary>
        /// Performs an boxing conversion custom <see cref="Point"/> struct to <see cref="System.ValueType"/> class.
        /// </summary>
        /// <param name="point"><see cref="Point"/> object.</param>
        /// <returns><see cref="System.ValueType"/> object.</returns>
        public static ValueType BoxToValueType(Point point) => throw new NotImplementedException();

        /// <summary>
        /// Performs an boxing conversion custom <see cref="Point"/> struct to <see cref="IColorable"/> interface.
        /// </summary>
        /// <param name="point"><see cref="Point"/> object.</param>
        /// <returns><see cref="IColorable"/> object.</returns>
        public static IColorable BoxToIColorable(Point point) => throw new NotImplementedException();

        /// <summary>
        /// Performs an boxing conversion build-in <see cref="System.Int32"/> struct to <see cref="System.Object"/> class.
        /// </summary>
        /// <param name="value"><see cref="System.Int32"/> object.</param>
        /// <returns><see cref="System.Object"/> object.</returns>
        public static object BoxToObject(int value) => throw new NotImplementedException();

        /// <summary>
        /// Performs an boxing conversion build-in <see cref="System.Int32"/> struct to <see cref="System.ValueType"/> class.
        /// </summary>
        /// <param name="value"><see cref="System.Int32"/> object.</param>
        /// <returns><see cref="System.ValueType"/> object.</returns>
        public static ValueType BoxToValueType(int value) => throw new NotImplementedException();

        /// <summary>
        /// Performs an boxing conversion build-in <see cref="System.Int32"/> struct to <see cref="System.IFormattable"/> interface.
        /// </summary>
        /// <param name="value"><see cref="System.Int32"/> object.</param>
        /// <returns><see cref="System.IFormattable"/> object.</returns>
        public static IFormattable BoxToIFormattable(int value) => throw new NotImplementedException();

        /// <summary>
        /// Performs an boxing conversion custom <see cref="Color"/> enum to <see cref="System.Object"/> class.
        /// </summary>
        /// <param name="color"><see cref="Color"/> object.</param>
        /// <returns><see cref="System.Object"/> object.</returns>
        public static object BoxToObject(Color color) => throw new NotImplementedException();

        /// <summary>
        /// Performs an boxing conversion custom <see cref="Color"/> enum to <see cref="System.ValueType"/> class.
        /// </summary>
        /// <param name="color"><see cref="System.Int32"/> object.</param>
        /// <returns><see cref="System.ValueType"/> object.</returns>
        public static ValueType BoxToValueType(Color color) => throw new NotImplementedException();

        /// <summary>
        /// Performs an boxing conversion custom <see cref="Color"/> enum to <see cref="System.Enum"/> class.
        /// </summary>
        /// <param name="color"><see cref="Color"/> object.</param>
        /// <returns><see cref="System.Enum"/> object.</returns>
        public static Enum BoxToEnum(Color color) => throw new NotImplementedException();
    }
}
