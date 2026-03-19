using System.Diagnostics;
using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using CheemsVanityItems.Common.Players;

namespace CheemsVanityItems.Content.Items.Armor.Vanity
{
	[AutoloadEquip(EquipType.Head)]
	public class DrPigeonHead : ModItem
	{
		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 20;

			// Common values for every boss mask
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(copper: 50, silver: 1);
			Item.vanity = true;
			Item.maxStack = 1;
		}

		public override void UpdateVanity(Player player) {
			player.GetModPlayer<DrPigeonPlayer>().DoEffects = true;
		}

		public override void UpdateEquip(Player player) {
			player.GetModPlayer<DrPigeonPlayer>().DoEffects = true;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Feather, 15);
			recipe.AddIngredient(ItemID.EmptyBucket, 1);
			recipe.AddTile(TileID.Loom);
			recipe.Register();
		}
	}
}