import { DragonPage } from './app.po';

describe('dragon App', () => {
  let page: DragonPage;

  beforeEach(() => {
    page = new DragonPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!');
  });
});
