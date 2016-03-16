using System;
using System.Collections.Generic;
using Android.Runtime;

namespace AChartEngine.Renderers {

	public partial class DefaultRenderer 
    {
        static IntPtr id_setTextTypeface_Ljava_lang_String_I;
		public virtual unsafe void SetTextTypeface (string p0, Android.Graphics.Typeface p1)
		{
			if (id_setTextTypeface_Ljava_lang_String_I == IntPtr.Zero)
				id_setTextTypeface_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setTextTypeface", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTextTypeface_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextTypeface", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
