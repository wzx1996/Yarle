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

namespace org.flamerat.Yarle
{
    public static partial class Yarle
    {
        /// <summary>
        /// Get a dummy list contains a certain amount of dummy element
        /// </summary>
        /// <param name="count">the amount of elements in the dummy list</param>
        /// <returns>A dummy list of <code>count</code> elements</returns>
        public static IEnumerable<object> Repeat(int count) {
            while (count > 0) {
                yield return null;
                count--;
            }
        }

        public static IEnumerable<T> Repeat<T>(int count,T element) {
            return Repeat(count).Select(x => element);
        }

        public static IEnumerable<T> Repeat<T>(int count,Func<T> elementGenerator) {
            return Repeat(count).Select(x => elementGenerator());
        }

        public static IEnumerable<T> Repeat<T>(int count,Func<object,T> elementGenerator) {
            return Repeat(count).Select(elementGenerator);
        }

        /// <summary>
        /// Get a list of int from <code>0</code> to <code>count-1</code>
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IEnumerable<int> Cardinal(int count) {
            for (int i = 0; i < count; i++) yield return i;
        }

        /// <summary>
        /// Get a list of int from <code>from</code> to <code>to</code>
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static IEnumerable<int> Cardinal(int from, int to) {
            for (int i = from; i <= to; i++) yield return i;
        }

        /// <summary>
        /// Get a list of int from <code>from</code> to <code>to</code> at <code>step</code> incremental
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public static IEnumerable<int> Cardinal(int from, int to, int step) {
            for (int i = from; i <= to; i += step) yield return i;
        }

        /// <summary>
        /// Get a list of double from <code>from</code> to <code>to</code> at <code>step</code> incremental
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public static IEnumerable<double> Cardinal(double from, double to, double step) {
            for (double i = from; i <= to; i += step) yield return i; 
        }

        /// <summary>
        /// vector: int * int
        /// </summary>
        public struct IntInt {
            public int X;
            public int Y; 
            public IntInt(int x,int y) {
                X = x;
                Y = y;
            }
        }

        /// <summary>
        /// Get a jagged list of elements that indicates it's position, 
        /// that <code>X</code> ranges from <code>0</code> to <code>width-1</code>,
        /// <code>Y</code> ranges from <code>0</code> to <code>height-1</code>
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static IEnumerable<IEnumerable<IntInt>> Grid(int width, int height) {
            for (int i = 0; i < height; i++) yield return Cardinal(width).Select(x=>new IntInt(x,i));
        }

    }
}
