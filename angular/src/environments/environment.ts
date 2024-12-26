import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'projectName',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44385/',
    redirectUri: baseUrl,
    clientId: 'projectName_App',
    responseType: 'code',
    scope: 'offline_access projectName',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44385',
      rootNamespace: 'projectName',
    },
  },
} as Environment;
