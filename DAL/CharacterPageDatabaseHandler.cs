using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CharacterPageDatabaseHandler
    {
        DBContext context;
        public CharacterPageDatabaseHandler()
        {
            context = new DBContext();
        }

        public void CreateCharacterPage(CharacterPageDTO characterPage)
        {
            context.CharacterPages.Add(characterPage);
            context.SaveChanges();
        }

        public void UpdateCharacterPage(CharacterPageDTO characterPage)
        {
            CharacterPageDTO DbCharacterPage = context.CharacterPages.Where(t => t.Id == characterPage.Id).FirstOrDefault();
            if (DbCharacterPage != null)
            {
                DbCharacterPage.Id = characterPage.Id;
                DbCharacterPage.CharacterName = characterPage.CharacterName;
                DbCharacterPage.ParagraphName = characterPage.ParagraphName;
                DbCharacterPage.Text = characterPage.Text;
                context.SaveChanges();
            }
        }

        public void DeleteCharacterPage(CharacterPageDTO characterPage)
        {
            CharacterPageDTO toDelete = GetCharacterPage(characterPage.Id);
            context.CharacterPages.Remove(toDelete);
            context.SaveChanges();
        }

        public IEnumerable<CharacterPageDTO> GetAllCharacterPages()
        {
            return context.CharacterPages;
        }

        public CharacterPageDTO GetCharacterPage(int characterPageId)
        {
            return context.CharacterPages.Where(t => t.Id == characterPageId).FirstOrDefault();
        }

    }
}
