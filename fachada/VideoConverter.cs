using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fachada {
    internal class VideoConverter {
        public static string ConvertVideo(string arch, TipoVideo tipo) {
            if (tipo == TipoVideo.AudioMixer) {
                return AudioMixerTV.Convertir(arch);
            }else if (tipo == TipoVideo.VideoFile) {
                return VideoFileTV.ConvierteAVF(arch, "2");
            }
                return "";
        }
    }
}
