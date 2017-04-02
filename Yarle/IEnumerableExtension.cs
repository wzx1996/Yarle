// Copyright 2017 FlameRat
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.flamerat.Yarle {
    public static partial class Yarle {
        /// <summary>
        /// Works similarly to <code>Select()</code> but yields no return
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="action"></param>
        /// <see cref="System.Linq.Enumerable.Select{TSource, TResult}(IEnumerable{TSource}, Func{TSource, TResult})"/>
        public static void ForEach<T>(this IEnumerable<T> collection,Action<T> action) {
            foreach (T element in collection) action(element);
        }

        /// <summary>
        /// Works similarly to <code>SelectMany()</code> but yields no return
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="action"></param>
        /// <see cref="System.Linq.Enumerable.SelectMany{TSource, TResult}(IEnumerable{TSource}, Func{TSource, IEnumerable{TResult}})"/>
        public static void ForEachEach<T>(this IEnumerable<IEnumerable<T>> collection,Action<T> action) {
            foreach (IEnumerable<T> element in collection) element.ForEach(action);
        }

        /// <summary>
        /// Yields a range of element, <paramref name="first"/> and <paramref name="last"/> starts from <code>0</code>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        public static IEnumerable<T> PickRange<T>(this IEnumerable<T> collection,int first,int last) {
            return collection.Skip(first).Take(last - first);
        }

        /// <summary>
        /// Similar to <code>PickRange()</code> but for jagged list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="firstRow"></param>
        /// <param name="lastRow"></param>
        /// <param name="firstColumn"></param>
        /// <param name="lastColumn"></param>
        /// <returns></returns>
        /// <see cref="PickRange{T}(IEnumerable{T}, int, int)"/>
        public static IEnumerable<IEnumerable<T>> PickSubarea<T>(this IEnumerable<IEnumerable<T>> collection,int firstRow,int lastRow,int firstColumn,int lastColumn) {
            foreach (IEnumerable<T> element in collection.PickRange(firstRow, lastRow)) yield return element.PickRange(firstColumn, lastColumn);
        }

        /// <summary>
        /// Turn jagged 2D list to a single 1D list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> collection) {
            return collection.SelectMany(x => x);
        }

        /// <summary>
        /// Similar to <code>SelectMany()</code> but preserves the jagged structure of the list
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="collection"></param>
        /// <param name="mapper"></param>
        /// <returns></returns>
        public static IEnumerable<IEnumerable<T2>> GridMap<T1,T2>(this IEnumerable<IEnumerable<T1>> collection,Func<T1,T2> mapper) {
            foreach (IEnumerable<T1> element in collection) yield return element.Select(mapper);
        }

        public static T[,] ToArray2D<T>(this IEnumerable<IEnumerable<T>> collection) {
            int column = collection.Select(x => x.Count()).Max();
            int row = collection.Count();
            T[,] result = new T[row, column];
            int i = 0;
            int j = 0;

            foreach(var element in collection) {
                foreach(var value in element) {
                    result[i, j] = value;
                    j++;
                }
                i++;
                j = 0;
            }
            return result;
        }

        public static T[][] ToArray2DJagged<T>(this IEnumerable<IEnumerable<T>> collection) {
            return collection.Select(x => x.ToArray()).ToArray();
        }



    }
}
