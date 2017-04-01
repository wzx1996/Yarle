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
    public partial class Yarle {
        public static IEnumerable<IEnumerable<T>> AsJaggedEnumerable<T>(this T[,] grid) {
            var row = grid.GetLength(0);
            var column = grid.GetLength(1);
            for(int i = 0; i < row; i++) {
                yield return grid._YieldRow(column,i);
            }
        }

        private static IEnumerable<T> _YieldRow<T>(this T[,] grid,int stride,int row) {
            for (int j = 0; j < stride; j++) {
                yield return grid[row, j];
            }
        }

        public static IEnumerable<IEnumerable<T>> AsJaggedEnumerable<T>(this T[][] grid) {
            return grid.AsEnumerable().Select(x => x.AsEnumerable());
        }

        public static T[][] ToJaggedArray<T>(this T[,] arrayMD) {
            return arrayMD.AsJaggedEnumerable().ToArray2DJagged();
        }

        public static T[,] ToMultiDimensionArray<T>(this T[][] arrayJagged) {
            return arrayJagged.ToArray2D();
        }
    }
}
