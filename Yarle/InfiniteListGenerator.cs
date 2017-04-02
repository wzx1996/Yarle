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
        /// Generates an infinite list, the first element is <paramref name="first"/>, 
        /// subsequent element would be generated from the previous element via
        /// the <paramref name="generator"/> function
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="generator"></param>
        /// <param name="first"></param>
        /// <returns></returns>
        public static IEnumerable<T> InfiniteList<T>(Func<T, T> generator, T first) {
            T last = first;
            T current;
            yield return first;
            while (true) {
                yield return current = generator(last);
                last = current;
            }
        }

        /// <summary>
        /// Generates an infinite list, the first element is <paramref name="first"/>, 
        /// the second element is <paramref name="second"/>
        /// subsequent element would be generated from the previous two elements via
        /// the <paramref name="generator"/> function
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="generator"></param>
        /// <param name="first"></param>
        /// <returns></returns>
        public static IEnumerable<T> InfiniteList<T>(Func<T, T, T> generator, T first, T second) {
            T secondLast = first;
            T last = second;
            T current;
            yield return first;
            yield return second;
            while (true) {
                yield return current = generator(secondLast, last);
                secondLast = last;
                last = current;
            }
        }


        //For compatibility issue, might have to uncomment the following code.

        //public static IEnumerable<object> InfiniteList(Func<object, object> generator, object first) {
        //    return InfiniteList<object>(generator, first);
        //}

        //public static IEnumerable<object> InfiniteList(Func<object, object, object> generator, object first, object second) {
        //    return InfiniteList<object>(generator, first, second);
        //}
    }
}

