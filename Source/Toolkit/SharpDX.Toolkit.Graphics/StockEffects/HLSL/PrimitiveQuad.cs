﻿//------------------------------------------------------------------------------
// <auto-generated>
//     SharpDX Toolkit Compiler File Generated:
//     Effect [Toolkit::PrimitiveQuad]
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharpDX.Toolkit.Graphics 
{
    public partial class PrimitiveQuad
    {
        private static readonly SharpDX.Toolkit.Graphics.EffectData effectBytecode = SharpDX.Toolkit.Graphics.EffectData.Load(new byte[] {
84, 75, 70, 88, 85, 6, 0, 0, 1, 1, 0, 0, 83, 72, 68, 82, 247, 5, 0, 0, 2, 1, 26, 84, 111, 111, 108, 107, 105, 116, 58, 58, 80, 114, 105, 109, 105, 116, 105, 118, 101, 81, 117, 97, 100, 58, 58, 86, 83, 0, 0, 0, 0, 0, 0, 145, 0, 0, 192, 5, 68, 88, 66, 67, 14, 
160, 138, 50, 43, 137, 56, 78, 186, 5, 131, 53, 226, 190, 238, 29, 1, 0, 0, 0, 192, 2, 0, 0, 4, 0, 0, 0, 48, 0, 0, 0, 4, 1, 0, 0, 16, 2, 0, 0, 104, 2, 0, 0, 65, 111, 110, 57, 204, 0, 0, 0, 204, 0, 0, 0, 0, 2, 254, 255, 152, 0, 0, 0, 52, 
0, 0, 0, 1, 0, 36, 0, 0, 0, 48, 0, 0, 0, 48, 0, 0, 0, 36, 0, 1, 0, 48, 0, 1, 0, 0, 0, 4, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 254, 255, 31, 0, 0, 2, 5, 0, 0, 128, 0, 0, 15, 144, 31, 0, 0, 2, 5, 0, 1, 128, 1, 
0, 15, 144, 5, 0, 0, 3, 0, 0, 15, 128, 1, 0, 85, 144, 2, 0, 228, 160, 4, 0, 0, 4, 0, 0, 15, 128, 1, 0, 0, 144, 1, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 0, 0, 15, 128, 1, 0, 170, 144, 3, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 0, 
0, 15, 128, 1, 0, 255, 144, 4, 0, 228, 160, 0, 0, 228, 128, 4, 0, 0, 4, 0, 0, 3, 192, 0, 0, 255, 128, 0, 0, 228, 160, 0, 0, 228, 128, 1, 0, 0, 2, 0, 0, 12, 192, 0, 0, 228, 128, 1, 0, 0, 2, 0, 0, 3, 224, 0, 0, 228, 144, 255, 255, 0, 0, 83, 
72, 68, 82, 4, 1, 0, 0, 64, 0, 1, 0, 65, 0, 0, 0, 89, 0, 0, 4, 70, 142, 32, 0, 1, 0, 0, 0, 4, 0, 0, 0, 95, 0, 0, 3, 50, 16, 16, 0, 0, 0, 0, 0, 95, 0, 0, 3, 242, 16, 16, 0, 1, 0, 0, 0, 101, 0, 0, 3, 50, 32, 16, 0, 0, 
0, 0, 0, 103, 0, 0, 4, 242, 32, 16, 0, 1, 0, 0, 0, 1, 0, 0, 0, 104, 0, 0, 2, 1, 0, 0, 0, 54, 0, 0, 5, 50, 32, 16, 0, 0, 0, 0, 0, 70, 16, 16, 0, 0, 0, 0, 0, 56, 0, 0, 8, 242, 0, 16, 0, 0, 0, 0, 0, 86, 21, 16, 0, 1, 
0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 1, 0, 0, 0, 50, 0, 0, 10, 242, 0, 16, 0, 0, 0, 0, 0, 6, 16, 16, 0, 1, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 0, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 50, 0, 0, 10, 242, 0, 16, 0, 0, 
0, 0, 0, 166, 26, 16, 0, 1, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 2, 0, 0, 0, 70, 14, 16, 0, 0, 0, 0, 0, 50, 0, 0, 10, 242, 32, 16, 0, 1, 0, 0, 0, 246, 31, 16, 0, 1, 0, 0, 0, 70, 142, 32, 0, 1, 0, 0, 0, 3, 0, 0, 0, 70, 
14, 16, 0, 0, 0, 0, 0, 62, 0, 0, 1, 73, 83, 71, 78, 80, 0, 0, 0, 2, 0, 0, 0, 8, 0, 0, 0, 56, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 3, 3, 0, 0, 65, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 
0, 0, 0, 1, 0, 0, 0, 15, 15, 0, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 171, 171, 171, 79, 83, 71, 78, 80, 0, 0, 0, 2, 0, 0, 0, 8, 0, 0, 0, 56, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 
0, 0, 0, 0, 0, 0, 0, 3, 12, 0, 0, 65, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 15, 0, 0, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 171, 171, 171, 240, 152, 113, 224, 2, 
8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 0, 0, 3, 3, 0, 0, 11, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 1, 0, 3, 15, 0, 0, 1, 124, 68, 88, 66, 67, 254, 118, 247, 211, 7, 45, 220, 246, 124, 193, 104, 192, 172, 244, 94, 238, 1, 0, 0, 0, 124, 0, 0, 
0, 1, 0, 0, 0, 36, 0, 0, 0, 73, 83, 71, 78, 80, 0, 0, 0, 2, 0, 0, 0, 8, 0, 0, 0, 56, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 3, 3, 0, 0, 65, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 
0, 1, 0, 0, 0, 15, 15, 0, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 83, 86, 95, 80, 111, 115, 105, 116, 105, 111, 110, 0, 171, 171, 171, 247, 78, 118, 157, 2, 8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 0, 0, 3, 3, 0, 0, 11, 83, 86, 95, 80, 111, 115, 105, 116, 105, 
111, 110, 0, 1, 1, 3, 15, 0, 0, 0, 0, 0, 0, 0, 1, 16, 80, 114, 111, 106, 101, 99, 116, 105, 111, 110, 77, 97, 116, 114, 105, 120, 64, 1, 15, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 2, 3, 0, 0, 64, 4, 4, 0, 1, 16, 80, 114, 111, 106, 
101, 99, 116, 105, 111, 110, 77, 97, 116, 114, 105, 120, 4, 26, 1, 1, 0, 4, 0, 0, 0, 0, 0, 145, 0, 0, 128, 3, 68, 88, 66, 67, 118, 182, 60, 204, 78, 49, 117, 52, 83, 100, 48, 208, 63, 32, 67, 142, 1, 0, 0, 0, 128, 1, 0, 0, 4, 0, 0, 0, 48, 0, 0, 0, 
156, 0, 0, 0, 24, 1, 0, 0, 76, 1, 0, 0, 65, 111, 110, 57, 100, 0, 0, 0, 100, 0, 0, 0, 0, 2, 255, 255, 60, 0, 0, 0, 40, 0, 0, 0, 0, 0, 40, 0, 0, 0, 40, 0, 0, 0, 40, 0, 1, 0, 36, 0, 0, 0, 40, 0, 0, 0, 0, 0, 0, 2, 255, 255, 
31, 0, 0, 2, 0, 0, 0, 128, 0, 0, 3, 176, 31, 0, 0, 2, 0, 0, 0, 144, 0, 8, 15, 160, 66, 0, 0, 3, 0, 0, 15, 128, 0, 0, 228, 176, 0, 8, 228, 160, 1, 0, 0, 2, 0, 8, 15, 128, 0, 0, 228, 128, 255, 255, 0, 0, 83, 72, 68, 82, 116, 0, 0, 0, 
64, 0, 0, 0, 29, 0, 0, 0, 89, 0, 0, 4, 70, 142, 32, 0, 0, 0, 0, 0, 1, 0, 0, 0, 90, 0, 0, 3, 0, 96, 16, 0, 0, 0, 0, 0, 88, 24, 0, 4, 0, 112, 16, 0, 0, 0, 0, 0, 85, 85, 0, 0, 98, 16, 0, 3, 50, 16, 16, 0, 0, 0, 0, 0, 
101, 0, 0, 3, 242, 32, 16, 0, 0, 0, 0, 0, 69, 0, 0, 9, 242, 32, 16, 0, 0, 0, 0, 0, 70, 16, 16, 0, 0, 0, 0, 0, 70, 126, 16, 0, 0, 0, 0, 0, 0, 96, 16, 0, 0, 0, 0, 0, 62, 0, 0, 1, 73, 83, 71, 78, 44, 0, 0, 0, 1, 0, 0, 0, 
8, 0, 0, 0, 32, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 3, 3, 0, 0, 84, 69, 88, 67, 79, 79, 82, 68, 0, 171, 171, 171, 79, 83, 71, 78, 44, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 32, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 15, 0, 0, 0, 83, 86, 95, 84, 97, 114, 103, 101, 116, 0, 171, 171, 243, 120, 124, 238, 1, 8, 84, 69, 88, 67, 79, 79, 82, 68, 0, 0, 0, 3, 3, 0, 0, 0, 0, 0, 0, 0, 1, 9, 83, 86, 95, 84, 97, 114, 103, 101, 
116, 0, 0, 64, 3, 15, 0, 0, 0, 0, 0, 0, 0, 1, 10, 80, 97, 114, 97, 109, 101, 116, 101, 114, 115, 0, 0, 3, 14, 84, 101, 120, 116, 117, 114, 101, 83, 97, 109, 112, 108, 101, 114, 4, 10, 0, 1, 7, 84, 101, 120, 116, 117, 114, 101, 4, 7, 0, 1, 10, 80, 97, 114, 97, 
109, 101, 116, 101, 114, 115, 4, 26, 0, 1, 69, 70, 70, 88, 74, 0, 0, 0, 22, 84, 111, 111, 108, 107, 105, 116, 58, 58, 80, 114, 105, 109, 105, 116, 105, 118, 101, 81, 117, 97, 100, 0, 1, 1, 11, 83, 112, 114, 105, 116, 101, 66, 97, 116, 99, 104, 2, 0, 0, 0, 0, 0, 0, 1, 
6, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 6, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 
        });
    }
}
