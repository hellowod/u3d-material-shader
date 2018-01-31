Shader "Custom/Queue Blue"{
	Properties{
		_Color("Color", Color) = (1,1,1,1)
	}

	// Blue
	SubShader{
		Tags{ "Queue" = "Geometry" "IgnoreProjector" = "True" "RenderType" = "Opaque" }
		LOD 200

		//Cull Back

		//ZTest Off
		//ZTest LEqual
		//ZWrite Off

		//Blend SrcAlpha OneMinusSrcAlpha

		CGINCLUDE
		#include "UnityCG.cginc"

		float4 _Color;

		struct v2f {
			float4 vertex:SV_POSITION;
			float2 uv:TEXCOORD0;
		};

		v2f vert(appdata_base v) {
			v2f o;
			o.vertex = UnityObjectToClipPos(v.vertex);
			o.uv = v.texcoord;
			return o;
		}

		fixed4 frag(v2f i) : Color {
			return _Color;
		}
		ENDCG

		Pass {
			Tags { "LightMode" = "ForwardBase" }

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			ENDCG
		}
	}
	Fallback "Legacy Shaders/VertexLit"
}