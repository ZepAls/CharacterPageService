using DAL;
using DTO;

namespace BLL
{
    public class CharacterPageHandler
    {
        private CharacterPageDatabaseHandler databaseHandler;
        public CharacterPageHandler()
        {
            databaseHandler = new CharacterPageDatabaseHandler();
        }

        public void CreateCharacterPage(CharacterPageDTO characterPage)
        {
            databaseHandler.CreateCharacterPage(characterPage);
        }

        public void UpdateCharacterPage(CharacterPageDTO characterPage)
        {
            databaseHandler.UpdateCharacterPage(characterPage);
        }

        public void DeleteCharacterPage(CharacterPageDTO characterPage)
        {
            databaseHandler.DeleteCharacterPage(characterPage);
        }

        public IEnumerable<CharacterPageDTO> GetAllCharacterPages()
        {
            return databaseHandler.GetAllCharacterPages();
        }

        public CharacterPageDTO GetCharacterPage(int CharacterPageId)
        {
            return databaseHandler.GetCharacterPage(CharacterPageId);
        }

    }
}
