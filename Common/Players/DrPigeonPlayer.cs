using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CheemsVanityItems.Common.Players
{   
    public class DrPigeonPlayer : ModPlayer
    {
		public bool DoEffects; // This helper property controls if the audio and visual effects of the vanity should be applied.

        public override void ResetEffects()
        {
            // Reset the flag every frame so the effect doesn't persist when the hat is removed
            DoEffects = false;
        }
		public override void ModifyHurt(ref Player.HurtModifiers modifiers) {
			if (DoEffects) {
				modifiers.DisableSound();
			}
		}

		public override void OnHurt(Player.HurtInfo info) {
			if (DoEffects) {
                SoundStyle customHurtSound = new SoundStyle("CheemsVanityItems/Assets/Sounds/DrPigeonHurt");
                SoundEngine.PlaySound(customHurtSound, Player.Center);
			}
		}
    }

}