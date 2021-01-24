import { ThuHoachTemplatePage } from './app.po';

describe('ThuHoach App', function() {
  let page: ThuHoachTemplatePage;

  beforeEach(() => {
    page = new ThuHoachTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
