using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasualScience.OpenGL
{

    public partial class NativeConstants
    {

        /// __gl3_h_ -> 
        /// Error generating expression: Value cannot be null.
        ///Parameter name: node
        public const string @__gl3_h_ = "";

        /// APIENTRYP -> APIENTRY *
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string APIENTRYP = "APIENTRY *";

        /// GLAPI -> extern
        /// Error generating expression: Value extern is not resolved
        public const string GLAPI = "extern";

        /// GL_DEPTH_BUFFER_BIT -> 0x00000100
        public const int GL_DEPTH_BUFFER_BIT = 256;

        /// GL_STENCIL_BUFFER_BIT -> 0x00000400
        public const int GL_STENCIL_BUFFER_BIT = 1024;

        /// GL_COLOR_BUFFER_BIT -> 0x00004000
        public const int GL_COLOR_BUFFER_BIT = 16384;

        /// GL_FALSE -> 0
        public const int GL_FALSE = 0;

        /// GL_TRUE -> 1
        public const int GL_TRUE = 1;

        /// GL_POINTS -> 0x0000
        public const int GL_POINTS = 0;

        /// GL_LINES -> 0x0001
        public const int GL_LINES = 1;

        /// GL_LINE_LOOP -> 0x0002
        public const int GL_LINE_LOOP = 2;

        /// GL_LINE_STRIP -> 0x0003
        public const int GL_LINE_STRIP = 3;

        /// GL_TRIANGLES -> 0x0004
        public const int GL_TRIANGLES = 4;

        /// GL_TRIANGLE_STRIP -> 0x0005
        public const int GL_TRIANGLE_STRIP = 5;

        /// GL_TRIANGLE_FAN -> 0x0006
        public const int GL_TRIANGLE_FAN = 6;

        /// GL_NEVER -> 0x0200
        public const int GL_NEVER = 512;

        /// GL_LESS -> 0x0201
        public const int GL_LESS = 513;

        /// GL_EQUAL -> 0x0202
        public const int GL_EQUAL = 514;

        /// GL_LEQUAL -> 0x0203
        public const int GL_LEQUAL = 515;

        /// GL_GREATER -> 0x0204
        public const int GL_GREATER = 516;

        /// GL_NOTEQUAL -> 0x0205
        public const int GL_NOTEQUAL = 517;

        /// GL_GEQUAL -> 0x0206
        public const int GL_GEQUAL = 518;

        /// GL_ALWAYS -> 0x0207
        public const int GL_ALWAYS = 519;

        /// GL_ZERO -> 0
        public const int GL_ZERO = 0;

        /// GL_ONE -> 1
        public const int GL_ONE = 1;

        /// GL_SRC_COLOR -> 0x0300
        public const int GL_SRC_COLOR = 768;

        /// GL_ONE_MINUS_SRC_COLOR -> 0x0301
        public const int GL_ONE_MINUS_SRC_COLOR = 769;

        /// GL_SRC_ALPHA -> 0x0302
        public const int GL_SRC_ALPHA = 770;

        /// GL_ONE_MINUS_SRC_ALPHA -> 0x0303
        public const int GL_ONE_MINUS_SRC_ALPHA = 771;

        /// GL_DST_ALPHA -> 0x0304
        public const int GL_DST_ALPHA = 772;

        /// GL_ONE_MINUS_DST_ALPHA -> 0x0305
        public const int GL_ONE_MINUS_DST_ALPHA = 773;

        /// GL_DST_COLOR -> 0x0306
        public const int GL_DST_COLOR = 774;

        /// GL_ONE_MINUS_DST_COLOR -> 0x0307
        public const int GL_ONE_MINUS_DST_COLOR = 775;

        /// GL_SRC_ALPHA_SATURATE -> 0x0308
        public const int GL_SRC_ALPHA_SATURATE = 776;

        /// GL_NONE -> 0
        public const int GL_NONE = 0;

        /// GL_FRONT_LEFT -> 0x0400
        public const int GL_FRONT_LEFT = 1024;

        /// GL_FRONT_RIGHT -> 0x0401
        public const int GL_FRONT_RIGHT = 1025;

        /// GL_BACK_LEFT -> 0x0402
        public const int GL_BACK_LEFT = 1026;

        /// GL_BACK_RIGHT -> 0x0403
        public const int GL_BACK_RIGHT = 1027;

        /// GL_FRONT -> 0x0404
        public const int GL_FRONT = 1028;

        /// GL_BACK -> 0x0405
        public const int GL_BACK = 1029;

        /// GL_LEFT -> 0x0406
        public const int GL_LEFT = 1030;

        /// GL_RIGHT -> 0x0407
        public const int GL_RIGHT = 1031;

        /// GL_FRONT_AND_BACK -> 0x0408
        public const int GL_FRONT_AND_BACK = 1032;

        /// GL_NO_ERROR -> 0
        public const int GL_NO_ERROR = 0;

        /// GL_INVALID_ENUM -> 0x0500
        public const int GL_INVALID_ENUM = 1280;

        /// GL_INVALID_VALUE -> 0x0501
        public const int GL_INVALID_VALUE = 1281;

        /// GL_INVALID_OPERATION -> 0x0502
        public const int GL_INVALID_OPERATION = 1282;

        /// GL_OUT_OF_MEMORY -> 0x0505
        public const int GL_OUT_OF_MEMORY = 1285;

        /// GL_CW -> 0x0900
        public const int GL_CW = 2304;

        /// GL_CCW -> 0x0901
        public const int GL_CCW = 2305;

        /// GL_POINT_SIZE -> 0x0B11
        public const int GL_POINT_SIZE = 2833;

        /// GL_POINT_SIZE_RANGE -> 0x0B12
        public const int GL_POINT_SIZE_RANGE = 2834;

        /// GL_POINT_SIZE_GRANULARITY -> 0x0B13
        public const int GL_POINT_SIZE_GRANULARITY = 2835;

        /// GL_LINE_SMOOTH -> 0x0B20
        public const int GL_LINE_SMOOTH = 2848;

        /// GL_LINE_WIDTH -> 0x0B21
        public const int GL_LINE_WIDTH = 2849;

        /// GL_LINE_WIDTH_RANGE -> 0x0B22
        public const int GL_LINE_WIDTH_RANGE = 2850;

        /// GL_LINE_WIDTH_GRANULARITY -> 0x0B23
        public const int GL_LINE_WIDTH_GRANULARITY = 2851;

        /// GL_POLYGON_SMOOTH -> 0x0B41
        public const int GL_POLYGON_SMOOTH = 2881;

        /// GL_CULL_FACE -> 0x0B44
        public const int GL_CULL_FACE = 2884;

        /// GL_CULL_FACE_MODE -> 0x0B45
        public const int GL_CULL_FACE_MODE = 2885;

        /// GL_FRONT_FACE -> 0x0B46
        public const int GL_FRONT_FACE = 2886;

        /// GL_DEPTH_RANGE -> 0x0B70
        public const int GL_DEPTH_RANGE = 2928;

        /// GL_DEPTH_TEST -> 0x0B71
        public const int GL_DEPTH_TEST = 2929;

        /// GL_DEPTH_WRITEMASK -> 0x0B72
        public const int GL_DEPTH_WRITEMASK = 2930;

        /// GL_DEPTH_CLEAR_VALUE -> 0x0B73
        public const int GL_DEPTH_CLEAR_VALUE = 2931;

        /// GL_DEPTH_FUNC -> 0x0B74
        public const int GL_DEPTH_FUNC = 2932;

        /// GL_STENCIL_TEST -> 0x0B90
        public const int GL_STENCIL_TEST = 2960;

        /// GL_STENCIL_CLEAR_VALUE -> 0x0B91
        public const int GL_STENCIL_CLEAR_VALUE = 2961;

        /// GL_STENCIL_FUNC -> 0x0B92
        public const int GL_STENCIL_FUNC = 2962;

        /// GL_STENCIL_VALUE_MASK -> 0x0B93
        public const int GL_STENCIL_VALUE_MASK = 2963;

        /// GL_STENCIL_FAIL -> 0x0B94
        public const int GL_STENCIL_FAIL = 2964;

        /// GL_STENCIL_PASS_DEPTH_FAIL -> 0x0B95
        public const int GL_STENCIL_PASS_DEPTH_FAIL = 2965;

        /// GL_STENCIL_PASS_DEPTH_PASS -> 0x0B96
        public const int GL_STENCIL_PASS_DEPTH_PASS = 2966;

        /// GL_STENCIL_REF -> 0x0B97
        public const int GL_STENCIL_REF = 2967;

        /// GL_STENCIL_WRITEMASK -> 0x0B98
        public const int GL_STENCIL_WRITEMASK = 2968;

        /// GL_VIEWPORT -> 0x0BA2
        public const int GL_VIEWPORT = 2978;

        /// GL_DITHER -> 0x0BD0
        public const int GL_DITHER = 3024;

        /// GL_BLEND_DST -> 0x0BE0
        public const int GL_BLEND_DST = 3040;

        /// GL_BLEND_SRC -> 0x0BE1
        public const int GL_BLEND_SRC = 3041;

        /// GL_BLEND -> 0x0BE2
        public const int GL_BLEND = 3042;

        /// GL_LOGIC_OP_MODE -> 0x0BF0
        public const int GL_LOGIC_OP_MODE = 3056;

        /// GL_COLOR_LOGIC_OP -> 0x0BF2
        public const int GL_COLOR_LOGIC_OP = 3058;

        /// GL_DRAW_BUFFER -> 0x0C01
        public const int GL_DRAW_BUFFER = 3073;

        /// GL_READ_BUFFER -> 0x0C02
        public const int GL_READ_BUFFER = 3074;

        /// GL_SCISSOR_BOX -> 0x0C10
        public const int GL_SCISSOR_BOX = 3088;

        /// GL_SCISSOR_TEST -> 0x0C11
        public const int GL_SCISSOR_TEST = 3089;

        /// GL_COLOR_CLEAR_VALUE -> 0x0C22
        public const int GL_COLOR_CLEAR_VALUE = 3106;

        /// GL_COLOR_WRITEMASK -> 0x0C23
        public const int GL_COLOR_WRITEMASK = 3107;

        /// GL_DOUBLEBUFFER -> 0x0C32
        public const int GL_DOUBLEBUFFER = 3122;

        /// GL_STEREO -> 0x0C33
        public const int GL_STEREO = 3123;

        /// GL_LINE_SMOOTH_HINT -> 0x0C52
        public const int GL_LINE_SMOOTH_HINT = 3154;

        /// GL_POLYGON_SMOOTH_HINT -> 0x0C53
        public const int GL_POLYGON_SMOOTH_HINT = 3155;

        /// GL_UNPACK_SWAP_BYTES -> 0x0CF0
        public const int GL_UNPACK_SWAP_BYTES = 3312;

        /// GL_UNPACK_LSB_FIRST -> 0x0CF1
        public const int GL_UNPACK_LSB_FIRST = 3313;

        /// GL_UNPACK_ROW_LENGTH -> 0x0CF2
        public const int GL_UNPACK_ROW_LENGTH = 3314;

        /// GL_UNPACK_SKIP_ROWS -> 0x0CF3
        public const int GL_UNPACK_SKIP_ROWS = 3315;

        /// GL_UNPACK_SKIP_PIXELS -> 0x0CF4
        public const int GL_UNPACK_SKIP_PIXELS = 3316;

        /// GL_UNPACK_ALIGNMENT -> 0x0CF5
        public const int GL_UNPACK_ALIGNMENT = 3317;

        /// GL_PACK_SWAP_BYTES -> 0x0D00
        public const int GL_PACK_SWAP_BYTES = 3328;

        /// GL_PACK_LSB_FIRST -> 0x0D01
        public const int GL_PACK_LSB_FIRST = 3329;

        /// GL_PACK_ROW_LENGTH -> 0x0D02
        public const int GL_PACK_ROW_LENGTH = 3330;

        /// GL_PACK_SKIP_ROWS -> 0x0D03
        public const int GL_PACK_SKIP_ROWS = 3331;

        /// GL_PACK_SKIP_PIXELS -> 0x0D04
        public const int GL_PACK_SKIP_PIXELS = 3332;

        /// GL_PACK_ALIGNMENT -> 0x0D05
        public const int GL_PACK_ALIGNMENT = 3333;

        /// GL_MAX_TEXTURE_SIZE -> 0x0D33
        public const int GL_MAX_TEXTURE_SIZE = 3379;

        /// GL_MAX_VIEWPORT_DIMS -> 0x0D3A
        public const int GL_MAX_VIEWPORT_DIMS = 3386;

        /// GL_SUBPIXEL_BITS -> 0x0D50
        public const int GL_SUBPIXEL_BITS = 3408;

        /// GL_TEXTURE_1D -> 0x0DE0
        public const int GL_TEXTURE_1D = 3552;

        /// GL_TEXTURE_2D -> 0x0DE1
        public const int GL_TEXTURE_2D = 3553;

        /// GL_POLYGON_OFFSET_UNITS -> 0x2A00
        public const int GL_POLYGON_OFFSET_UNITS = 10752;

        /// GL_POLYGON_OFFSET_POINT -> 0x2A01
        public const int GL_POLYGON_OFFSET_POINT = 10753;

        /// GL_POLYGON_OFFSET_LINE -> 0x2A02
        public const int GL_POLYGON_OFFSET_LINE = 10754;

        /// GL_POLYGON_OFFSET_FILL -> 0x8037
        public const int GL_POLYGON_OFFSET_FILL = 32823;

        /// GL_POLYGON_OFFSET_FACTOR -> 0x8038
        public const int GL_POLYGON_OFFSET_FACTOR = 32824;

        /// GL_TEXTURE_BINDING_1D -> 0x8068
        public const int GL_TEXTURE_BINDING_1D = 32872;

        /// GL_TEXTURE_BINDING_2D -> 0x8069
        public const int GL_TEXTURE_BINDING_2D = 32873;

        /// GL_TEXTURE_WIDTH -> 0x1000
        public const int GL_TEXTURE_WIDTH = 4096;

        /// GL_TEXTURE_HEIGHT -> 0x1001
        public const int GL_TEXTURE_HEIGHT = 4097;

        /// GL_TEXTURE_INTERNAL_FORMAT -> 0x1003
        public const int GL_TEXTURE_INTERNAL_FORMAT = 4099;

        /// GL_TEXTURE_BORDER_COLOR -> 0x1004
        public const int GL_TEXTURE_BORDER_COLOR = 4100;

        /// GL_TEXTURE_RED_SIZE -> 0x805C
        public const int GL_TEXTURE_RED_SIZE = 32860;

        /// GL_TEXTURE_GREEN_SIZE -> 0x805D
        public const int GL_TEXTURE_GREEN_SIZE = 32861;

        /// GL_TEXTURE_BLUE_SIZE -> 0x805E
        public const int GL_TEXTURE_BLUE_SIZE = 32862;

        /// GL_TEXTURE_ALPHA_SIZE -> 0x805F
        public const int GL_TEXTURE_ALPHA_SIZE = 32863;

        /// GL_DONT_CARE -> 0x1100
        public const int GL_DONT_CARE = 4352;

        /// GL_FASTEST -> 0x1101
        public const int GL_FASTEST = 4353;

        /// GL_NICEST -> 0x1102
        public const int GL_NICEST = 4354;

        /// GL_BYTE -> 0x1400
        public const int GL_BYTE = 5120;

        /// GL_UNSIGNED_BYTE -> 0x1401
        public const int GL_UNSIGNED_BYTE = 5121;

        /// GL_SHORT -> 0x1402
        public const int GL_SHORT = 5122;

        /// GL_UNSIGNED_SHORT -> 0x1403
        public const int GL_UNSIGNED_SHORT = 5123;

        /// GL_INT -> 0x1404
        public const int GL_INT = 5124;

        /// GL_UNSIGNED_INT -> 0x1405
        public const int GL_UNSIGNED_INT = 5125;

        /// GL_FLOAT -> 0x1406
        public const int GL_FLOAT = 5126;

        /// GL_DOUBLE -> 0x140A
        public const int GL_DOUBLE = 5130;

        /// GL_CLEAR -> 0x1500
        public const int GL_CLEAR = 5376;

        /// GL_AND -> 0x1501
        public const int GL_AND = 5377;

        /// GL_AND_REVERSE -> 0x1502
        public const int GL_AND_REVERSE = 5378;

        /// GL_COPY -> 0x1503
        public const int GL_COPY = 5379;

        /// GL_AND_INVERTED -> 0x1504
        public const int GL_AND_INVERTED = 5380;

        /// GL_NOOP -> 0x1505
        public const int GL_NOOP = 5381;

        /// GL_XOR -> 0x1506
        public const int GL_XOR = 5382;

        /// GL_OR -> 0x1507
        public const int GL_OR = 5383;

        /// GL_NOR -> 0x1508
        public const int GL_NOR = 5384;

        /// GL_EQUIV -> 0x1509
        public const int GL_EQUIV = 5385;

        /// GL_INVERT -> 0x150A
        public const int GL_INVERT = 5386;

        /// GL_OR_REVERSE -> 0x150B
        public const int GL_OR_REVERSE = 5387;

        /// GL_COPY_INVERTED -> 0x150C
        public const int GL_COPY_INVERTED = 5388;

        /// GL_OR_INVERTED -> 0x150D
        public const int GL_OR_INVERTED = 5389;

        /// GL_NAND -> 0x150E
        public const int GL_NAND = 5390;

        /// GL_SET -> 0x150F
        public const int GL_SET = 5391;

        /// GL_TEXTURE -> 0x1702
        public const int GL_TEXTURE = 5890;

        /// GL_COLOR -> 0x1800
        public const int GL_COLOR = 6144;

        /// GL_DEPTH -> 0x1801
        public const int GL_DEPTH = 6145;

        /// GL_STENCIL -> 0x1802
        public const int GL_STENCIL = 6146;

        /// GL_STENCIL_INDEX -> 0x1901
        public const int GL_STENCIL_INDEX = 6401;

        /// GL_DEPTH_COMPONENT -> 0x1902
        public const int GL_DEPTH_COMPONENT = 6402;

        /// GL_RED -> 0x1903
        public const int GL_RED = 6403;

        /// GL_GREEN -> 0x1904
        public const int GL_GREEN = 6404;

        /// GL_BLUE -> 0x1905
        public const int GL_BLUE = 6405;

        /// GL_ALPHA -> 0x1906
        public const int GL_ALPHA = 6406;

        /// GL_RGB -> 0x1907
        public const int GL_RGB = 6407;

        /// GL_RGBA -> 0x1908
        public const int GL_RGBA = 6408;

        /// GL_POINT -> 0x1B00
        public const int GL_POINT = 6912;

        /// GL_LINE -> 0x1B01
        public const int GL_LINE = 6913;

        /// GL_FILL -> 0x1B02
        public const int GL_FILL = 6914;

        /// GL_KEEP -> 0x1E00
        public const int GL_KEEP = 7680;

        /// GL_REPLACE -> 0x1E01
        public const int GL_REPLACE = 7681;

        /// GL_INCR -> 0x1E02
        public const int GL_INCR = 7682;

        /// GL_DECR -> 0x1E03
        public const int GL_DECR = 7683;

        /// GL_VENDOR -> 0x1F00
        public const int GL_VENDOR = 7936;

        /// GL_RENDERER -> 0x1F01
        public const int GL_RENDERER = 7937;

        /// GL_VERSION -> 0x1F02
        public const int GL_VERSION = 7938;

        /// GL_EXTENSIONS -> 0x1F03
        public const int GL_EXTENSIONS = 7939;

        /// GL_NEAREST -> 0x2600
        public const int GL_NEAREST = 9728;

        /// GL_LINEAR -> 0x2601
        public const int GL_LINEAR = 9729;

        /// GL_NEAREST_MIPMAP_NEAREST -> 0x2700
        public const int GL_NEAREST_MIPMAP_NEAREST = 9984;

        /// GL_LINEAR_MIPMAP_NEAREST -> 0x2701
        public const int GL_LINEAR_MIPMAP_NEAREST = 9985;

        /// GL_NEAREST_MIPMAP_LINEAR -> 0x2702
        public const int GL_NEAREST_MIPMAP_LINEAR = 9986;

        /// GL_LINEAR_MIPMAP_LINEAR -> 0x2703
        public const int GL_LINEAR_MIPMAP_LINEAR = 9987;

        /// GL_TEXTURE_MAG_FILTER -> 0x2800
        public const int GL_TEXTURE_MAG_FILTER = 10240;

        /// GL_TEXTURE_MIN_FILTER -> 0x2801
        public const int GL_TEXTURE_MIN_FILTER = 10241;

        /// GL_TEXTURE_WRAP_S -> 0x2802
        public const int GL_TEXTURE_WRAP_S = 10242;

        /// GL_TEXTURE_WRAP_T -> 0x2803
        public const int GL_TEXTURE_WRAP_T = 10243;

        /// GL_PROXY_TEXTURE_1D -> 0x8063
        public const int GL_PROXY_TEXTURE_1D = 32867;

        /// GL_PROXY_TEXTURE_2D -> 0x8064
        public const int GL_PROXY_TEXTURE_2D = 32868;

        /// GL_REPEAT -> 0x2901
        public const int GL_REPEAT = 10497;

        /// GL_R3_G3_B2 -> 0x2A10
        public const int GL_R3_G3_B2 = 10768;

        /// GL_RGB4 -> 0x804F
        public const int GL_RGB4 = 32847;

        /// GL_RGB5 -> 0x8050
        public const int GL_RGB5 = 32848;

        /// GL_RGB8 -> 0x8051
        public const int GL_RGB8 = 32849;

        /// GL_RGB10 -> 0x8052
        public const int GL_RGB10 = 32850;

        /// GL_RGB12 -> 0x8053
        public const int GL_RGB12 = 32851;

        /// GL_RGB16 -> 0x8054
        public const int GL_RGB16 = 32852;

        /// GL_RGBA2 -> 0x8055
        public const int GL_RGBA2 = 32853;

        /// GL_RGBA4 -> 0x8056
        public const int GL_RGBA4 = 32854;

        /// GL_RGB5_A1 -> 0x8057
        public const int GL_RGB5_A1 = 32855;

        /// GL_RGBA8 -> 0x8058
        public const int GL_RGBA8 = 32856;

        /// GL_RGB10_A2 -> 0x8059
        public const int GL_RGB10_A2 = 32857;

        /// GL_RGBA12 -> 0x805A
        public const int GL_RGBA12 = 32858;

        /// GL_RGBA16 -> 0x805B
        public const int GL_RGBA16 = 32859;

        /// GL_UNSIGNED_BYTE_3_3_2 -> 0x8032
        public const int GL_UNSIGNED_BYTE_3_3_2 = 32818;

        /// GL_UNSIGNED_SHORT_4_4_4_4 -> 0x8033
        public const int GL_UNSIGNED_SHORT_4_4_4_4 = 32819;

        /// GL_UNSIGNED_SHORT_5_5_5_1 -> 0x8034
        public const int GL_UNSIGNED_SHORT_5_5_5_1 = 32820;

        /// GL_UNSIGNED_INT_8_8_8_8 -> 0x8035
        public const int GL_UNSIGNED_INT_8_8_8_8 = 32821;

        /// GL_UNSIGNED_INT_10_10_10_2 -> 0x8036
        public const int GL_UNSIGNED_INT_10_10_10_2 = 32822;

        /// GL_TEXTURE_BINDING_3D -> 0x806A
        public const int GL_TEXTURE_BINDING_3D = 32874;

        /// GL_PACK_SKIP_IMAGES -> 0x806B
        public const int GL_PACK_SKIP_IMAGES = 32875;

        /// GL_PACK_IMAGE_HEIGHT -> 0x806C
        public const int GL_PACK_IMAGE_HEIGHT = 32876;

        /// GL_UNPACK_SKIP_IMAGES -> 0x806D
        public const int GL_UNPACK_SKIP_IMAGES = 32877;

        /// GL_UNPACK_IMAGE_HEIGHT -> 0x806E
        public const int GL_UNPACK_IMAGE_HEIGHT = 32878;

        /// GL_TEXTURE_3D -> 0x806F
        public const int GL_TEXTURE_3D = 32879;

        /// GL_PROXY_TEXTURE_3D -> 0x8070
        public const int GL_PROXY_TEXTURE_3D = 32880;

        /// GL_TEXTURE_DEPTH -> 0x8071
        public const int GL_TEXTURE_DEPTH = 32881;

        /// GL_TEXTURE_WRAP_R -> 0x8072
        public const int GL_TEXTURE_WRAP_R = 32882;

        /// GL_MAX_3D_TEXTURE_SIZE -> 0x8073
        public const int GL_MAX_3D_TEXTURE_SIZE = 32883;

        /// GL_UNSIGNED_BYTE_2_3_3_REV -> 0x8362
        public const int GL_UNSIGNED_BYTE_2_3_3_REV = 33634;

        /// GL_UNSIGNED_SHORT_5_6_5 -> 0x8363
        public const int GL_UNSIGNED_SHORT_5_6_5 = 33635;

        /// GL_UNSIGNED_SHORT_5_6_5_REV -> 0x8364
        public const int GL_UNSIGNED_SHORT_5_6_5_REV = 33636;

        /// GL_UNSIGNED_SHORT_4_4_4_4_REV -> 0x8365
        public const int GL_UNSIGNED_SHORT_4_4_4_4_REV = 33637;

        /// GL_UNSIGNED_SHORT_1_5_5_5_REV -> 0x8366
        public const int GL_UNSIGNED_SHORT_1_5_5_5_REV = 33638;

        /// GL_UNSIGNED_INT_8_8_8_8_REV -> 0x8367
        public const int GL_UNSIGNED_INT_8_8_8_8_REV = 33639;

        /// GL_UNSIGNED_INT_2_10_10_10_REV -> 0x8368
        public const int GL_UNSIGNED_INT_2_10_10_10_REV = 33640;

        /// GL_BGR -> 0x80E0
        public const int GL_BGR = 32992;

        /// GL_BGRA -> 0x80E1
        public const int GL_BGRA = 32993;

        /// GL_MAX_ELEMENTS_VERTICES -> 0x80E8
        public const int GL_MAX_ELEMENTS_VERTICES = 33000;

        /// GL_MAX_ELEMENTS_INDICES -> 0x80E9
        public const int GL_MAX_ELEMENTS_INDICES = 33001;

        /// GL_CLAMP_TO_EDGE -> 0x812F
        public const int GL_CLAMP_TO_EDGE = 33071;

        /// GL_TEXTURE_MIN_LOD -> 0x813A
        public const int GL_TEXTURE_MIN_LOD = 33082;

        /// GL_TEXTURE_MAX_LOD -> 0x813B
        public const int GL_TEXTURE_MAX_LOD = 33083;

        /// GL_TEXTURE_BASE_LEVEL -> 0x813C
        public const int GL_TEXTURE_BASE_LEVEL = 33084;

        /// GL_TEXTURE_MAX_LEVEL -> 0x813D
        public const int GL_TEXTURE_MAX_LEVEL = 33085;

        /// GL_SMOOTH_POINT_SIZE_RANGE -> 0x0B12
        public const int GL_SMOOTH_POINT_SIZE_RANGE = 2834;

        /// GL_SMOOTH_POINT_SIZE_GRANULARITY -> 0x0B13
        public const int GL_SMOOTH_POINT_SIZE_GRANULARITY = 2835;

        /// GL_SMOOTH_LINE_WIDTH_RANGE -> 0x0B22
        public const int GL_SMOOTH_LINE_WIDTH_RANGE = 2850;

        /// GL_SMOOTH_LINE_WIDTH_GRANULARITY -> 0x0B23
        public const int GL_SMOOTH_LINE_WIDTH_GRANULARITY = 2851;

        /// GL_ALIASED_LINE_WIDTH_RANGE -> 0x846E
        public const int GL_ALIASED_LINE_WIDTH_RANGE = 33902;

        /// GL_CONSTANT_COLOR -> 0x8001
        public const int GL_CONSTANT_COLOR = 32769;

        /// GL_ONE_MINUS_CONSTANT_COLOR -> 0x8002
        public const int GL_ONE_MINUS_CONSTANT_COLOR = 32770;

        /// GL_CONSTANT_ALPHA -> 0x8003
        public const int GL_CONSTANT_ALPHA = 32771;

        /// GL_ONE_MINUS_CONSTANT_ALPHA -> 0x8004
        public const int GL_ONE_MINUS_CONSTANT_ALPHA = 32772;

        /// GL_BLEND_COLOR -> 0x8005
        public const int GL_BLEND_COLOR = 32773;

        /// GL_FUNC_ADD -> 0x8006
        public const int GL_FUNC_ADD = 32774;

        /// GL_MIN -> 0x8007
        public const int GL_MIN = 32775;

        /// GL_MAX -> 0x8008
        public const int GL_MAX = 32776;

        /// GL_BLEND_EQUATION -> 0x8009
        public const int GL_BLEND_EQUATION = 32777;

        /// GL_FUNC_SUBTRACT -> 0x800A
        public const int GL_FUNC_SUBTRACT = 32778;

        /// GL_FUNC_REVERSE_SUBTRACT -> 0x800B
        public const int GL_FUNC_REVERSE_SUBTRACT = 32779;

        /// GL_TEXTURE0 -> 0x84C0
        public const int GL_TEXTURE0 = 33984;

        /// GL_TEXTURE1 -> 0x84C1
        public const int GL_TEXTURE1 = 33985;

        /// GL_TEXTURE2 -> 0x84C2
        public const int GL_TEXTURE2 = 33986;

        /// GL_TEXTURE3 -> 0x84C3
        public const int GL_TEXTURE3 = 33987;

        /// GL_TEXTURE4 -> 0x84C4
        public const int GL_TEXTURE4 = 33988;

        /// GL_TEXTURE5 -> 0x84C5
        public const int GL_TEXTURE5 = 33989;

        /// GL_TEXTURE6 -> 0x84C6
        public const int GL_TEXTURE6 = 33990;

        /// GL_TEXTURE7 -> 0x84C7
        public const int GL_TEXTURE7 = 33991;

        /// GL_TEXTURE8 -> 0x84C8
        public const int GL_TEXTURE8 = 33992;

        /// GL_TEXTURE9 -> 0x84C9
        public const int GL_TEXTURE9 = 33993;

        /// GL_TEXTURE10 -> 0x84CA
        public const int GL_TEXTURE10 = 33994;

        /// GL_TEXTURE11 -> 0x84CB
        public const int GL_TEXTURE11 = 33995;

        /// GL_TEXTURE12 -> 0x84CC
        public const int GL_TEXTURE12 = 33996;

        /// GL_TEXTURE13 -> 0x84CD
        public const int GL_TEXTURE13 = 33997;

        /// GL_TEXTURE14 -> 0x84CE
        public const int GL_TEXTURE14 = 33998;

        /// GL_TEXTURE15 -> 0x84CF
        public const int GL_TEXTURE15 = 33999;

        /// GL_TEXTURE16 -> 0x84D0
        public const int GL_TEXTURE16 = 34000;

        /// GL_TEXTURE17 -> 0x84D1
        public const int GL_TEXTURE17 = 34001;

        /// GL_TEXTURE18 -> 0x84D2
        public const int GL_TEXTURE18 = 34002;

        /// GL_TEXTURE19 -> 0x84D3
        public const int GL_TEXTURE19 = 34003;

        /// GL_TEXTURE20 -> 0x84D4
        public const int GL_TEXTURE20 = 34004;

        /// GL_TEXTURE21 -> 0x84D5
        public const int GL_TEXTURE21 = 34005;

        /// GL_TEXTURE22 -> 0x84D6
        public const int GL_TEXTURE22 = 34006;

        /// GL_TEXTURE23 -> 0x84D7
        public const int GL_TEXTURE23 = 34007;

        /// GL_TEXTURE24 -> 0x84D8
        public const int GL_TEXTURE24 = 34008;

        /// GL_TEXTURE25 -> 0x84D9
        public const int GL_TEXTURE25 = 34009;

        /// GL_TEXTURE26 -> 0x84DA
        public const int GL_TEXTURE26 = 34010;

        /// GL_TEXTURE27 -> 0x84DB
        public const int GL_TEXTURE27 = 34011;

        /// GL_TEXTURE28 -> 0x84DC
        public const int GL_TEXTURE28 = 34012;

        /// GL_TEXTURE29 -> 0x84DD
        public const int GL_TEXTURE29 = 34013;

        /// GL_TEXTURE30 -> 0x84DE
        public const int GL_TEXTURE30 = 34014;

        /// GL_TEXTURE31 -> 0x84DF
        public const int GL_TEXTURE31 = 34015;

        /// GL_ACTIVE_TEXTURE -> 0x84E0
        public const int GL_ACTIVE_TEXTURE = 34016;

        /// GL_MULTISAMPLE -> 0x809D
        public const int GL_MULTISAMPLE = 32925;

        /// GL_SAMPLE_ALPHA_TO_COVERAGE -> 0x809E
        public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 32926;

        /// GL_SAMPLE_ALPHA_TO_ONE -> 0x809F
        public const int GL_SAMPLE_ALPHA_TO_ONE = 32927;

        /// GL_SAMPLE_COVERAGE -> 0x80A0
        public const int GL_SAMPLE_COVERAGE = 32928;

        /// GL_SAMPLE_BUFFERS -> 0x80A8
        public const int GL_SAMPLE_BUFFERS = 32936;

        /// GL_SAMPLES -> 0x80A9
        public const int GL_SAMPLES = 32937;

        /// GL_SAMPLE_COVERAGE_VALUE -> 0x80AA
        public const int GL_SAMPLE_COVERAGE_VALUE = 32938;

        /// GL_SAMPLE_COVERAGE_INVERT -> 0x80AB
        public const int GL_SAMPLE_COVERAGE_INVERT = 32939;

        /// GL_TEXTURE_CUBE_MAP -> 0x8513
        public const int GL_TEXTURE_CUBE_MAP = 34067;

        /// GL_TEXTURE_BINDING_CUBE_MAP -> 0x8514
        public const int GL_TEXTURE_BINDING_CUBE_MAP = 34068;

        /// GL_TEXTURE_CUBE_MAP_POSITIVE_X -> 0x8515
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 34069;

        /// GL_TEXTURE_CUBE_MAP_NEGATIVE_X -> 0x8516
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 34070;

        /// GL_TEXTURE_CUBE_MAP_POSITIVE_Y -> 0x8517
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 34071;

        /// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y -> 0x8518
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 34072;

        /// GL_TEXTURE_CUBE_MAP_POSITIVE_Z -> 0x8519
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 34073;

        /// GL_TEXTURE_CUBE_MAP_NEGATIVE_Z -> 0x851A
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 34074;

        /// GL_PROXY_TEXTURE_CUBE_MAP -> 0x851B
        public const int GL_PROXY_TEXTURE_CUBE_MAP = 34075;

        /// GL_MAX_CUBE_MAP_TEXTURE_SIZE -> 0x851C
        public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE = 34076;

        /// GL_COMPRESSED_RGB -> 0x84ED
        public const int GL_COMPRESSED_RGB = 34029;

        /// GL_COMPRESSED_RGBA -> 0x84EE
        public const int GL_COMPRESSED_RGBA = 34030;

        /// GL_TEXTURE_COMPRESSION_HINT -> 0x84EF
        public const int GL_TEXTURE_COMPRESSION_HINT = 34031;

        /// GL_TEXTURE_COMPRESSED_IMAGE_SIZE -> 0x86A0
        public const int GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 34464;

        /// GL_TEXTURE_COMPRESSED -> 0x86A1
        public const int GL_TEXTURE_COMPRESSED = 34465;

        /// GL_NUM_COMPRESSED_TEXTURE_FORMATS -> 0x86A2
        public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 34466;

        /// GL_COMPRESSED_TEXTURE_FORMATS -> 0x86A3
        public const int GL_COMPRESSED_TEXTURE_FORMATS = 34467;

        /// GL_CLAMP_TO_BORDER -> 0x812D
        public const int GL_CLAMP_TO_BORDER = 33069;

        /// GL_BLEND_DST_RGB -> 0x80C8
        public const int GL_BLEND_DST_RGB = 32968;

        /// GL_BLEND_SRC_RGB -> 0x80C9
        public const int GL_BLEND_SRC_RGB = 32969;

        /// GL_BLEND_DST_ALPHA -> 0x80CA
        public const int GL_BLEND_DST_ALPHA = 32970;

        /// GL_BLEND_SRC_ALPHA -> 0x80CB
        public const int GL_BLEND_SRC_ALPHA = 32971;

        /// GL_POINT_FADE_THRESHOLD_SIZE -> 0x8128
        public const int GL_POINT_FADE_THRESHOLD_SIZE = 33064;

        /// GL_DEPTH_COMPONENT16 -> 0x81A5
        public const int GL_DEPTH_COMPONENT16 = 33189;

        /// GL_DEPTH_COMPONENT24 -> 0x81A6
        public const int GL_DEPTH_COMPONENT24 = 33190;

        /// GL_DEPTH_COMPONENT32 -> 0x81A7
        public const int GL_DEPTH_COMPONENT32 = 33191;

        /// GL_MIRRORED_REPEAT -> 0x8370
        public const int GL_MIRRORED_REPEAT = 33648;

        /// GL_MAX_TEXTURE_LOD_BIAS -> 0x84FD
        public const int GL_MAX_TEXTURE_LOD_BIAS = 34045;

        /// GL_TEXTURE_LOD_BIAS -> 0x8501
        public const int GL_TEXTURE_LOD_BIAS = 34049;

        /// GL_INCR_WRAP -> 0x8507
        public const int GL_INCR_WRAP = 34055;

        /// GL_DECR_WRAP -> 0x8508
        public const int GL_DECR_WRAP = 34056;

        /// GL_TEXTURE_DEPTH_SIZE -> 0x884A
        public const int GL_TEXTURE_DEPTH_SIZE = 34890;

        /// GL_TEXTURE_COMPARE_MODE -> 0x884C
        public const int GL_TEXTURE_COMPARE_MODE = 34892;

        /// GL_TEXTURE_COMPARE_FUNC -> 0x884D
        public const int GL_TEXTURE_COMPARE_FUNC = 34893;

        /// GL_BUFFER_SIZE -> 0x8764
        public const int GL_BUFFER_SIZE = 34660;

        /// GL_BUFFER_USAGE -> 0x8765
        public const int GL_BUFFER_USAGE = 34661;

        /// GL_QUERY_COUNTER_BITS -> 0x8864
        public const int GL_QUERY_COUNTER_BITS = 34916;

        /// GL_CURRENT_QUERY -> 0x8865
        public const int GL_CURRENT_QUERY = 34917;

        /// GL_QUERY_RESULT -> 0x8866
        public const int GL_QUERY_RESULT = 34918;

        /// GL_QUERY_RESULT_AVAILABLE -> 0x8867
        public const int GL_QUERY_RESULT_AVAILABLE = 34919;

        /// GL_ARRAY_BUFFER -> 0x8892
        public const int GL_ARRAY_BUFFER = 34962;

        /// GL_ELEMENT_ARRAY_BUFFER -> 0x8893
        public const int GL_ELEMENT_ARRAY_BUFFER = 34963;

        /// GL_ARRAY_BUFFER_BINDING -> 0x8894
        public const int GL_ARRAY_BUFFER_BINDING = 34964;

        /// GL_ELEMENT_ARRAY_BUFFER_BINDING -> 0x8895
        public const int GL_ELEMENT_ARRAY_BUFFER_BINDING = 34965;

        /// GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING -> 0x889F
        public const int GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 34975;

        /// GL_READ_ONLY -> 0x88B8
        public const int GL_READ_ONLY = 35000;

        /// GL_WRITE_ONLY -> 0x88B9
        public const int GL_WRITE_ONLY = 35001;

        /// GL_READ_WRITE -> 0x88BA
        public const int GL_READ_WRITE = 35002;

        /// GL_BUFFER_ACCESS -> 0x88BB
        public const int GL_BUFFER_ACCESS = 35003;

        /// GL_BUFFER_MAPPED -> 0x88BC
        public const int GL_BUFFER_MAPPED = 35004;

        /// GL_BUFFER_MAP_POINTER -> 0x88BD
        public const int GL_BUFFER_MAP_POINTER = 35005;

        /// GL_STREAM_DRAW -> 0x88E0
        public const int GL_STREAM_DRAW = 35040;

        /// GL_STREAM_READ -> 0x88E1
        public const int GL_STREAM_READ = 35041;

        /// GL_STREAM_COPY -> 0x88E2
        public const int GL_STREAM_COPY = 35042;

        /// GL_STATIC_DRAW -> 0x88E4
        public const int GL_STATIC_DRAW = 35044;

        /// GL_STATIC_READ -> 0x88E5
        public const int GL_STATIC_READ = 35045;

        /// GL_STATIC_COPY -> 0x88E6
        public const int GL_STATIC_COPY = 35046;

        /// GL_DYNAMIC_DRAW -> 0x88E8
        public const int GL_DYNAMIC_DRAW = 35048;

        /// GL_DYNAMIC_READ -> 0x88E9
        public const int GL_DYNAMIC_READ = 35049;

        /// GL_DYNAMIC_COPY -> 0x88EA
        public const int GL_DYNAMIC_COPY = 35050;

        /// GL_SAMPLES_PASSED -> 0x8914
        public const int GL_SAMPLES_PASSED = 35092;

        /// GL_BLEND_EQUATION_RGB -> 0x8009
        public const int GL_BLEND_EQUATION_RGB = 32777;

        /// GL_VERTEX_ATTRIB_ARRAY_ENABLED -> 0x8622
        public const int GL_VERTEX_ATTRIB_ARRAY_ENABLED = 34338;

        /// GL_VERTEX_ATTRIB_ARRAY_SIZE -> 0x8623
        public const int GL_VERTEX_ATTRIB_ARRAY_SIZE = 34339;

        /// GL_VERTEX_ATTRIB_ARRAY_STRIDE -> 0x8624
        public const int GL_VERTEX_ATTRIB_ARRAY_STRIDE = 34340;

        /// GL_VERTEX_ATTRIB_ARRAY_TYPE -> 0x8625
        public const int GL_VERTEX_ATTRIB_ARRAY_TYPE = 34341;

        /// GL_CURRENT_VERTEX_ATTRIB -> 0x8626
        public const int GL_CURRENT_VERTEX_ATTRIB = 34342;

        /// GL_VERTEX_PROGRAM_POINT_SIZE -> 0x8642
        public const int GL_VERTEX_PROGRAM_POINT_SIZE = 34370;

        /// GL_VERTEX_ATTRIB_ARRAY_POINTER -> 0x8645
        public const int GL_VERTEX_ATTRIB_ARRAY_POINTER = 34373;

        /// GL_STENCIL_BACK_FUNC -> 0x8800
        public const int GL_STENCIL_BACK_FUNC = 34816;

        /// GL_STENCIL_BACK_FAIL -> 0x8801
        public const int GL_STENCIL_BACK_FAIL = 34817;

        /// GL_STENCIL_BACK_PASS_DEPTH_FAIL -> 0x8802
        public const int GL_STENCIL_BACK_PASS_DEPTH_FAIL = 34818;

        /// GL_STENCIL_BACK_PASS_DEPTH_PASS -> 0x8803
        public const int GL_STENCIL_BACK_PASS_DEPTH_PASS = 34819;

        /// GL_MAX_DRAW_BUFFERS -> 0x8824
        public const int GL_MAX_DRAW_BUFFERS = 34852;

        /// GL_DRAW_BUFFER0 -> 0x8825
        public const int GL_DRAW_BUFFER0 = 34853;

        /// GL_DRAW_BUFFER1 -> 0x8826
        public const int GL_DRAW_BUFFER1 = 34854;

        /// GL_DRAW_BUFFER2 -> 0x8827
        public const int GL_DRAW_BUFFER2 = 34855;

        /// GL_DRAW_BUFFER3 -> 0x8828
        public const int GL_DRAW_BUFFER3 = 34856;

        /// GL_DRAW_BUFFER4 -> 0x8829
        public const int GL_DRAW_BUFFER4 = 34857;

        /// GL_DRAW_BUFFER5 -> 0x882A
        public const int GL_DRAW_BUFFER5 = 34858;

        /// GL_DRAW_BUFFER6 -> 0x882B
        public const int GL_DRAW_BUFFER6 = 34859;

        /// GL_DRAW_BUFFER7 -> 0x882C
        public const int GL_DRAW_BUFFER7 = 34860;

        /// GL_DRAW_BUFFER8 -> 0x882D
        public const int GL_DRAW_BUFFER8 = 34861;

        /// GL_DRAW_BUFFER9 -> 0x882E
        public const int GL_DRAW_BUFFER9 = 34862;

        /// GL_DRAW_BUFFER10 -> 0x882F
        public const int GL_DRAW_BUFFER10 = 34863;

        /// GL_DRAW_BUFFER11 -> 0x8830
        public const int GL_DRAW_BUFFER11 = 34864;

        /// GL_DRAW_BUFFER12 -> 0x8831
        public const int GL_DRAW_BUFFER12 = 34865;

        /// GL_DRAW_BUFFER13 -> 0x8832
        public const int GL_DRAW_BUFFER13 = 34866;

        /// GL_DRAW_BUFFER14 -> 0x8833
        public const int GL_DRAW_BUFFER14 = 34867;

        /// GL_DRAW_BUFFER15 -> 0x8834
        public const int GL_DRAW_BUFFER15 = 34868;

        /// GL_BLEND_EQUATION_ALPHA -> 0x883D
        public const int GL_BLEND_EQUATION_ALPHA = 34877;

        /// GL_MAX_VERTEX_ATTRIBS -> 0x8869
        public const int GL_MAX_VERTEX_ATTRIBS = 34921;

        /// GL_VERTEX_ATTRIB_ARRAY_NORMALIZED -> 0x886A
        public const int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 34922;

        /// GL_MAX_TEXTURE_IMAGE_UNITS -> 0x8872
        public const int GL_MAX_TEXTURE_IMAGE_UNITS = 34930;

        /// GL_FRAGMENT_SHADER -> 0x8B30
        public const int GL_FRAGMENT_SHADER = 35632;

        /// GL_VERTEX_SHADER -> 0x8B31
        public const int GL_VERTEX_SHADER = 35633;

        /// GL_MAX_FRAGMENT_UNIFORM_COMPONENTS -> 0x8B49
        public const int GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 35657;

        /// GL_MAX_VERTEX_UNIFORM_COMPONENTS -> 0x8B4A
        public const int GL_MAX_VERTEX_UNIFORM_COMPONENTS = 35658;

        /// GL_MAX_VARYING_FLOATS -> 0x8B4B
        public const int GL_MAX_VARYING_FLOATS = 35659;

        /// GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS -> 0x8B4C
        public const int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 35660;

        /// GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS -> 0x8B4D
        public const int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 35661;

        /// GL_SHADER_TYPE -> 0x8B4F
        public const int GL_SHADER_TYPE = 35663;

        /// GL_FLOAT_VEC2 -> 0x8B50
        public const int GL_FLOAT_VEC2 = 35664;

        /// GL_FLOAT_VEC3 -> 0x8B51
        public const int GL_FLOAT_VEC3 = 35665;

        /// GL_FLOAT_VEC4 -> 0x8B52
        public const int GL_FLOAT_VEC4 = 35666;

        /// GL_INT_VEC2 -> 0x8B53
        public const int GL_INT_VEC2 = 35667;

        /// GL_INT_VEC3 -> 0x8B54
        public const int GL_INT_VEC3 = 35668;

        /// GL_INT_VEC4 -> 0x8B55
        public const int GL_INT_VEC4 = 35669;

        /// GL_BOOL -> 0x8B56
        public const int GL_BOOL = 35670;

        /// GL_BOOL_VEC2 -> 0x8B57
        public const int GL_BOOL_VEC2 = 35671;

        /// GL_BOOL_VEC3 -> 0x8B58
        public const int GL_BOOL_VEC3 = 35672;

        /// GL_BOOL_VEC4 -> 0x8B59
        public const int GL_BOOL_VEC4 = 35673;

        /// GL_FLOAT_MAT2 -> 0x8B5A
        public const int GL_FLOAT_MAT2 = 35674;

        /// GL_FLOAT_MAT3 -> 0x8B5B
        public const int GL_FLOAT_MAT3 = 35675;

        /// GL_FLOAT_MAT4 -> 0x8B5C
        public const int GL_FLOAT_MAT4 = 35676;

        /// GL_SAMPLER_1D -> 0x8B5D
        public const int GL_SAMPLER_1D = 35677;

        /// GL_SAMPLER_2D -> 0x8B5E
        public const int GL_SAMPLER_2D = 35678;

        /// GL_SAMPLER_3D -> 0x8B5F
        public const int GL_SAMPLER_3D = 35679;

        /// GL_SAMPLER_CUBE -> 0x8B60
        public const int GL_SAMPLER_CUBE = 35680;

        /// GL_SAMPLER_1D_SHADOW -> 0x8B61
        public const int GL_SAMPLER_1D_SHADOW = 35681;

        /// GL_SAMPLER_2D_SHADOW -> 0x8B62
        public const int GL_SAMPLER_2D_SHADOW = 35682;

        /// GL_DELETE_STATUS -> 0x8B80
        public const int GL_DELETE_STATUS = 35712;

        /// GL_COMPILE_STATUS -> 0x8B81
        public const int GL_COMPILE_STATUS = 35713;

        /// GL_LINK_STATUS -> 0x8B82
        public const int GL_LINK_STATUS = 35714;

        /// GL_VALIDATE_STATUS -> 0x8B83
        public const int GL_VALIDATE_STATUS = 35715;

        /// GL_INFO_LOG_LENGTH -> 0x8B84
        public const int GL_INFO_LOG_LENGTH = 35716;

        /// GL_ATTACHED_SHADERS -> 0x8B85
        public const int GL_ATTACHED_SHADERS = 35717;

        /// GL_ACTIVE_UNIFORMS -> 0x8B86
        public const int GL_ACTIVE_UNIFORMS = 35718;

        /// GL_ACTIVE_UNIFORM_MAX_LENGTH -> 0x8B87
        public const int GL_ACTIVE_UNIFORM_MAX_LENGTH = 35719;

        /// GL_SHADER_SOURCE_LENGTH -> 0x8B88
        public const int GL_SHADER_SOURCE_LENGTH = 35720;

        /// GL_ACTIVE_ATTRIBUTES -> 0x8B89
        public const int GL_ACTIVE_ATTRIBUTES = 35721;

        /// GL_ACTIVE_ATTRIBUTE_MAX_LENGTH -> 0x8B8A
        public const int GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 35722;

        /// GL_FRAGMENT_SHADER_DERIVATIVE_HINT -> 0x8B8B
        public const int GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 35723;

        /// GL_SHADING_LANGUAGE_VERSION -> 0x8B8C
        public const int GL_SHADING_LANGUAGE_VERSION = 35724;

        /// GL_CURRENT_PROGRAM -> 0x8B8D
        public const int GL_CURRENT_PROGRAM = 35725;

        /// GL_POINT_SPRITE_COORD_ORIGIN -> 0x8CA0
        public const int GL_POINT_SPRITE_COORD_ORIGIN = 36000;

        /// GL_LOWER_LEFT -> 0x8CA1
        public const int GL_LOWER_LEFT = 36001;

        /// GL_UPPER_LEFT -> 0x8CA2
        public const int GL_UPPER_LEFT = 36002;

        /// GL_STENCIL_BACK_REF -> 0x8CA3
        public const int GL_STENCIL_BACK_REF = 36003;

        /// GL_STENCIL_BACK_VALUE_MASK -> 0x8CA4
        public const int GL_STENCIL_BACK_VALUE_MASK = 36004;

        /// GL_STENCIL_BACK_WRITEMASK -> 0x8CA5
        public const int GL_STENCIL_BACK_WRITEMASK = 36005;

        /// GL_PIXEL_PACK_BUFFER -> 0x88EB
        public const int GL_PIXEL_PACK_BUFFER = 35051;

        /// GL_PIXEL_UNPACK_BUFFER -> 0x88EC
        public const int GL_PIXEL_UNPACK_BUFFER = 35052;

        /// GL_PIXEL_PACK_BUFFER_BINDING -> 0x88ED
        public const int GL_PIXEL_PACK_BUFFER_BINDING = 35053;

        /// GL_PIXEL_UNPACK_BUFFER_BINDING -> 0x88EF
        public const int GL_PIXEL_UNPACK_BUFFER_BINDING = 35055;

        /// GL_FLOAT_MAT2x3 -> 0x8B65
        public const int GL_FLOAT_MAT2x3 = 35685;

        /// GL_FLOAT_MAT2x4 -> 0x8B66
        public const int GL_FLOAT_MAT2x4 = 35686;

        /// GL_FLOAT_MAT3x2 -> 0x8B67
        public const int GL_FLOAT_MAT3x2 = 35687;

        /// GL_FLOAT_MAT3x4 -> 0x8B68
        public const int GL_FLOAT_MAT3x4 = 35688;

        /// GL_FLOAT_MAT4x2 -> 0x8B69
        public const int GL_FLOAT_MAT4x2 = 35689;

        /// GL_FLOAT_MAT4x3 -> 0x8B6A
        public const int GL_FLOAT_MAT4x3 = 35690;

        /// GL_SRGB -> 0x8C40
        public const int GL_SRGB = 35904;

        /// GL_SRGB8 -> 0x8C41
        public const int GL_SRGB8 = 35905;

        /// GL_SRGB_ALPHA -> 0x8C42
        public const int GL_SRGB_ALPHA = 35906;

        /// GL_SRGB8_ALPHA8 -> 0x8C43
        public const int GL_SRGB8_ALPHA8 = 35907;

        /// GL_COMPRESSED_SRGB -> 0x8C48
        public const int GL_COMPRESSED_SRGB = 35912;

        /// GL_COMPRESSED_SRGB_ALPHA -> 0x8C49
        public const int GL_COMPRESSED_SRGB_ALPHA = 35913;

        /// GL_COMPARE_REF_TO_TEXTURE -> 0x884E
        public const int GL_COMPARE_REF_TO_TEXTURE = 34894;

        /// GL_CLIP_DISTANCE0 -> 0x3000
        public const int GL_CLIP_DISTANCE0 = 12288;

        /// GL_CLIP_DISTANCE1 -> 0x3001
        public const int GL_CLIP_DISTANCE1 = 12289;

        /// GL_CLIP_DISTANCE2 -> 0x3002
        public const int GL_CLIP_DISTANCE2 = 12290;

        /// GL_CLIP_DISTANCE3 -> 0x3003
        public const int GL_CLIP_DISTANCE3 = 12291;

        /// GL_CLIP_DISTANCE4 -> 0x3004
        public const int GL_CLIP_DISTANCE4 = 12292;

        /// GL_CLIP_DISTANCE5 -> 0x3005
        public const int GL_CLIP_DISTANCE5 = 12293;

        /// GL_CLIP_DISTANCE6 -> 0x3006
        public const int GL_CLIP_DISTANCE6 = 12294;

        /// GL_CLIP_DISTANCE7 -> 0x3007
        public const int GL_CLIP_DISTANCE7 = 12295;

        /// GL_MAX_CLIP_DISTANCES -> 0x0D32
        public const int GL_MAX_CLIP_DISTANCES = 3378;

        /// GL_MAJOR_VERSION -> 0x821B
        public const int GL_MAJOR_VERSION = 33307;

        /// GL_MINOR_VERSION -> 0x821C
        public const int GL_MINOR_VERSION = 33308;

        /// GL_NUM_EXTENSIONS -> 0x821D
        public const int GL_NUM_EXTENSIONS = 33309;

        /// GL_CONTEXT_FLAGS -> 0x821E
        public const int GL_CONTEXT_FLAGS = 33310;

        /// GL_COMPRESSED_RED -> 0x8225
        public const int GL_COMPRESSED_RED = 33317;

        /// GL_COMPRESSED_RG -> 0x8226
        public const int GL_COMPRESSED_RG = 33318;

        /// GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT -> 0x0001
        public const int GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 1;

        /// GL_RGBA32F -> 0x8814
        public const int GL_RGBA32F = 34836;

        /// GL_RGB32F -> 0x8815
        public const int GL_RGB32F = 34837;

        /// GL_RGBA16F -> 0x881A
        public const int GL_RGBA16F = 34842;

        /// GL_RGB16F -> 0x881B
        public const int GL_RGB16F = 34843;

        /// GL_VERTEX_ATTRIB_ARRAY_INTEGER -> 0x88FD
        public const int GL_VERTEX_ATTRIB_ARRAY_INTEGER = 35069;

        /// GL_MAX_ARRAY_TEXTURE_LAYERS -> 0x88FF
        public const int GL_MAX_ARRAY_TEXTURE_LAYERS = 35071;

        /// GL_MIN_PROGRAM_TEXEL_OFFSET -> 0x8904
        public const int GL_MIN_PROGRAM_TEXEL_OFFSET = 35076;

        /// GL_MAX_PROGRAM_TEXEL_OFFSET -> 0x8905
        public const int GL_MAX_PROGRAM_TEXEL_OFFSET = 35077;

        /// GL_CLAMP_READ_COLOR -> 0x891C
        public const int GL_CLAMP_READ_COLOR = 35100;

        /// GL_FIXED_ONLY -> 0x891D
        public const int GL_FIXED_ONLY = 35101;

        /// GL_MAX_VARYING_COMPONENTS -> 0x8B4B
        public const int GL_MAX_VARYING_COMPONENTS = 35659;

        /// GL_TEXTURE_1D_ARRAY -> 0x8C18
        public const int GL_TEXTURE_1D_ARRAY = 35864;

        /// GL_PROXY_TEXTURE_1D_ARRAY -> 0x8C19
        public const int GL_PROXY_TEXTURE_1D_ARRAY = 35865;

        /// GL_TEXTURE_2D_ARRAY -> 0x8C1A
        public const int GL_TEXTURE_2D_ARRAY = 35866;

        /// GL_PROXY_TEXTURE_2D_ARRAY -> 0x8C1B
        public const int GL_PROXY_TEXTURE_2D_ARRAY = 35867;

        /// GL_TEXTURE_BINDING_1D_ARRAY -> 0x8C1C
        public const int GL_TEXTURE_BINDING_1D_ARRAY = 35868;

        /// GL_TEXTURE_BINDING_2D_ARRAY -> 0x8C1D
        public const int GL_TEXTURE_BINDING_2D_ARRAY = 35869;

        /// GL_R11F_G11F_B10F -> 0x8C3A
        public const int GL_R11F_G11F_B10F = 35898;

        /// GL_UNSIGNED_INT_10F_11F_11F_REV -> 0x8C3B
        public const int GL_UNSIGNED_INT_10F_11F_11F_REV = 35899;

        /// GL_RGB9_E5 -> 0x8C3D
        public const int GL_RGB9_E5 = 35901;

        /// GL_UNSIGNED_INT_5_9_9_9_REV -> 0x8C3E
        public const int GL_UNSIGNED_INT_5_9_9_9_REV = 35902;

        /// GL_TEXTURE_SHARED_SIZE -> 0x8C3F
        public const int GL_TEXTURE_SHARED_SIZE = 35903;

        /// GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH -> 0x8C76
        public const int GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 35958;

        /// GL_TRANSFORM_FEEDBACK_BUFFER_MODE -> 0x8C7F
        public const int GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 35967;

        /// GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS -> 0x8C80
        public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 35968;

        /// GL_TRANSFORM_FEEDBACK_VARYINGS -> 0x8C83
        public const int GL_TRANSFORM_FEEDBACK_VARYINGS = 35971;

        /// GL_TRANSFORM_FEEDBACK_BUFFER_START -> 0x8C84
        public const int GL_TRANSFORM_FEEDBACK_BUFFER_START = 35972;

        /// GL_TRANSFORM_FEEDBACK_BUFFER_SIZE -> 0x8C85
        public const int GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 35973;

        /// GL_PRIMITIVES_GENERATED -> 0x8C87
        public const int GL_PRIMITIVES_GENERATED = 35975;

        /// GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN -> 0x8C88
        public const int GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 35976;

        /// GL_RASTERIZER_DISCARD -> 0x8C89
        public const int GL_RASTERIZER_DISCARD = 35977;

        /// GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS -> 0x8C8A
        public const int GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 35978;

        /// GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS -> 0x8C8B
        public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 35979;

        /// GL_INTERLEAVED_ATTRIBS -> 0x8C8C
        public const int GL_INTERLEAVED_ATTRIBS = 35980;

        /// GL_SEPARATE_ATTRIBS -> 0x8C8D
        public const int GL_SEPARATE_ATTRIBS = 35981;

        /// GL_TRANSFORM_FEEDBACK_BUFFER -> 0x8C8E
        public const int GL_TRANSFORM_FEEDBACK_BUFFER = 35982;

        /// GL_TRANSFORM_FEEDBACK_BUFFER_BINDING -> 0x8C8F
        public const int GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 35983;

        /// GL_RGBA32UI -> 0x8D70
        public const int GL_RGBA32UI = 36208;

        /// GL_RGB32UI -> 0x8D71
        public const int GL_RGB32UI = 36209;

        /// GL_RGBA16UI -> 0x8D76
        public const int GL_RGBA16UI = 36214;

        /// GL_RGB16UI -> 0x8D77
        public const int GL_RGB16UI = 36215;

        /// GL_RGBA8UI -> 0x8D7C
        public const int GL_RGBA8UI = 36220;

        /// GL_RGB8UI -> 0x8D7D
        public const int GL_RGB8UI = 36221;

        /// GL_RGBA32I -> 0x8D82
        public const int GL_RGBA32I = 36226;

        /// GL_RGB32I -> 0x8D83
        public const int GL_RGB32I = 36227;

        /// GL_RGBA16I -> 0x8D88
        public const int GL_RGBA16I = 36232;

        /// GL_RGB16I -> 0x8D89
        public const int GL_RGB16I = 36233;

        /// GL_RGBA8I -> 0x8D8E
        public const int GL_RGBA8I = 36238;

        /// GL_RGB8I -> 0x8D8F
        public const int GL_RGB8I = 36239;

        /// GL_RED_INTEGER -> 0x8D94
        public const int GL_RED_INTEGER = 36244;

        /// GL_GREEN_INTEGER -> 0x8D95
        public const int GL_GREEN_INTEGER = 36245;

        /// GL_BLUE_INTEGER -> 0x8D96
        public const int GL_BLUE_INTEGER = 36246;

        /// GL_RGB_INTEGER -> 0x8D98
        public const int GL_RGB_INTEGER = 36248;

        /// GL_RGBA_INTEGER -> 0x8D99
        public const int GL_RGBA_INTEGER = 36249;

        /// GL_BGR_INTEGER -> 0x8D9A
        public const int GL_BGR_INTEGER = 36250;

        /// GL_BGRA_INTEGER -> 0x8D9B
        public const int GL_BGRA_INTEGER = 36251;

        /// GL_SAMPLER_1D_ARRAY -> 0x8DC0
        public const int GL_SAMPLER_1D_ARRAY = 36288;

        /// GL_SAMPLER_2D_ARRAY -> 0x8DC1
        public const int GL_SAMPLER_2D_ARRAY = 36289;

        /// GL_SAMPLER_1D_ARRAY_SHADOW -> 0x8DC3
        public const int GL_SAMPLER_1D_ARRAY_SHADOW = 36291;

        /// GL_SAMPLER_2D_ARRAY_SHADOW -> 0x8DC4
        public const int GL_SAMPLER_2D_ARRAY_SHADOW = 36292;

        /// GL_SAMPLER_CUBE_SHADOW -> 0x8DC5
        public const int GL_SAMPLER_CUBE_SHADOW = 36293;

        /// GL_UNSIGNED_INT_VEC2 -> 0x8DC6
        public const int GL_UNSIGNED_INT_VEC2 = 36294;

        /// GL_UNSIGNED_INT_VEC3 -> 0x8DC7
        public const int GL_UNSIGNED_INT_VEC3 = 36295;

        /// GL_UNSIGNED_INT_VEC4 -> 0x8DC8
        public const int GL_UNSIGNED_INT_VEC4 = 36296;

        /// GL_INT_SAMPLER_1D -> 0x8DC9
        public const int GL_INT_SAMPLER_1D = 36297;

        /// GL_INT_SAMPLER_2D -> 0x8DCA
        public const int GL_INT_SAMPLER_2D = 36298;

        /// GL_INT_SAMPLER_3D -> 0x8DCB
        public const int GL_INT_SAMPLER_3D = 36299;

        /// GL_INT_SAMPLER_CUBE -> 0x8DCC
        public const int GL_INT_SAMPLER_CUBE = 36300;

        /// GL_INT_SAMPLER_1D_ARRAY -> 0x8DCE
        public const int GL_INT_SAMPLER_1D_ARRAY = 36302;

        /// GL_INT_SAMPLER_2D_ARRAY -> 0x8DCF
        public const int GL_INT_SAMPLER_2D_ARRAY = 36303;

        /// GL_UNSIGNED_INT_SAMPLER_1D -> 0x8DD1
        public const int GL_UNSIGNED_INT_SAMPLER_1D = 36305;

        /// GL_UNSIGNED_INT_SAMPLER_2D -> 0x8DD2
        public const int GL_UNSIGNED_INT_SAMPLER_2D = 36306;

        /// GL_UNSIGNED_INT_SAMPLER_3D -> 0x8DD3
        public const int GL_UNSIGNED_INT_SAMPLER_3D = 36307;

        /// GL_UNSIGNED_INT_SAMPLER_CUBE -> 0x8DD4
        public const int GL_UNSIGNED_INT_SAMPLER_CUBE = 36308;

        /// GL_UNSIGNED_INT_SAMPLER_1D_ARRAY -> 0x8DD6
        public const int GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 36310;

        /// GL_UNSIGNED_INT_SAMPLER_2D_ARRAY -> 0x8DD7
        public const int GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 36311;

        /// GL_QUERY_WAIT -> 0x8E13
        public const int GL_QUERY_WAIT = 36371;

        /// GL_QUERY_NO_WAIT -> 0x8E14
        public const int GL_QUERY_NO_WAIT = 36372;

        /// GL_QUERY_BY_REGION_WAIT -> 0x8E15
        public const int GL_QUERY_BY_REGION_WAIT = 36373;

        /// GL_QUERY_BY_REGION_NO_WAIT -> 0x8E16
        public const int GL_QUERY_BY_REGION_NO_WAIT = 36374;

        /// GL_BUFFER_ACCESS_FLAGS -> 0x911F
        public const int GL_BUFFER_ACCESS_FLAGS = 37151;

        /// GL_BUFFER_MAP_LENGTH -> 0x9120
        public const int GL_BUFFER_MAP_LENGTH = 37152;

        /// GL_BUFFER_MAP_OFFSET -> 0x9121
        public const int GL_BUFFER_MAP_OFFSET = 37153;
    }

}
